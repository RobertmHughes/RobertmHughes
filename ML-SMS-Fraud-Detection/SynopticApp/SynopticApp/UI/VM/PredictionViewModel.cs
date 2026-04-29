using System.Linq;
using SynopticApp.UI.VM;
using System;
using SynopticApp.UI.Pages;
using System.Windows.Input;
using SMSFraudDetection.ML;

namespace SynopticApp.UI.VM
{
    public class PredictionViewModel :BaseViewModel
    {
        // defining proeprties for the user input - SMS message
        private string _resultText;
        public string ResultText
        {
            get => _resultText;
            set => SetProperty(ref _resultText, value);

        }

        // defining the proprty to hold the prediction result - Spam or Safe
        private string _predictionResult;
        public string PredictionResult
        {
            get => _predictionResult;
            set => SetProperty(ref _predictionResult, value);
        }

        // Creating commands for scanning the message, and clearing the output result area.
        public ICommand ScanCommand { get; }
        public ICommand ClearCommand { get; }

        public PredictionViewModel()
        {
            ScanCommand = new Command(async () => await Scan());
            ClearCommand = new Command(async () => await ClearResult());
        }
        //-------
        
        // Scan Message task that will give the user entered message to the ML Model
        public async Task Scan()
        {
            // Setting up relevant variables and setting the busy state to true.
            string ResultLabel;
            string ResultExplanation;
            IsBusy = true;

            PredictionResult = await Task.Run(string () =>
            {
                // Here the user ML 'message' is set to the user entered message,
                // and given to the SpamDetector Model as a new input for it to predict.
                var sampleData = new SpamDetector.ModelInput()
                {
                    Message = ResultText
                };

                // This if statement then determines the user output from the boolean results.
                // If the predicted label is 1, set the result label to 'Fraud' including its explanation
                if (SpamDetector.Predict(sampleData).PredictedLabel == 1)
                {
                    ResultLabel = "Fraud\n\n";

                    // Defined in Synoptic/ML/Explanation.cs
                    ResultExplanation = Explanation.GenerateExplanation(ResultText);

                    // simply connecting them to one output to return
                    return ResultLabel + ResultExplanation;
                }
                // if result is not 1, then it is safe.
                else
                {
                    return "Safe \n \n While this messages seems safe, never share personal information, or transfer money to unknown users.";
                }


            });
            // Process finished, busy = false and the user can now scan another message.
            IsBusy = false;
        }

    
        // Simple clear button to clear the Output result box.
        private Task ClearResult()
        {
            PredictionResult = null;
            return Task.CompletedTask;
        }
    }
}
