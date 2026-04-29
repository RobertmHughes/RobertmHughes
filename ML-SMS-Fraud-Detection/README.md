# 📱 SMS Fraud Detection using Machine Learning

> Final year dissertation project - BSc Cyber Security, Manchester Metropolitan University  
> **Grade: First-Class Honours**

A desktop application that uses machine learning to detect SMS-based fraud in real time. Users can submit a message, receive an instant spam/ham prediction, and get a plain-language explanation of why the model reached that result.

---

## 🧠 The problem

SMS fraud costs consumers billions every year - the Federal Trade Commission estimated scammers steal over $8.6 billion annually from US citizens alone. Existing tools offer little transparency or accessibility for everyday users. This project aimed to fix that with a clean, accurate, and explainable detection tool.

---

## 🎯 Project aims

- Build an efficient, high-performing ML model capable of classifying SMS messages as spam or legitimate
- Train and test the model against a large labelled dataset of spam and ham messages
- Deliver instant, accurate predictions with a clear explanation of the result
- Wrap everything in a simple, accessible user interface

---

## ⚙️ How it works

```
Training Dataset → FastForest ML Algorithm → SpamDetector Model
                                                      ↓
                    User inputs SMS message → Prediction engine → Result + Explanation → UI
```

The core model uses a **FastForest One-vs-All (OVA)** algorithm:

- **Ensemble learning** - multiple decision trees are trained in parallel, reducing overfitting
- **One-vs-All strategy** - separate binary classifiers are trained for each label (Spam / Ham)
- **Probabilistic scoring** - the class with the highest probability score across all classifiers wins

---

## 📊 Results

| Metric | Score |
|--------|-------|
| Model accuracy | **89%** |
| Classification type | Binary (Spam / Ham) |
| Algorithm | FastForest OVA |

Testing identified some false positives and negatives - noted as areas for further development and refinement.

---

## 🖥️ Final application

The finished application:
- Accepts a raw SMS message as input
- Analyses it through the trained SpamDetector model
- Returns a clear spam/ham result
- Provides a plain-language explanation of which language patterns influenced the prediction

---

## 🛠️ Tech stack

`C#` `ML.NET` `FastForest` `Visual Studio` `WinForms / WPF`

---

## 📁 Repository structure

```
sms-fraud-detection/
├── SynopticApp/              ← main Visual Studio project
├── Hughes_Robert_Report/     ← Dissertaion Report
├── SynopticApp Presentation/ ← Dissertation Presentation
└── README.md
```

---

## 📬 Get in touch

- 💼 [LinkedIn](https://www.linkedin.com/in/robert-hughes)
- 📧 robertmarkhughes2@gmail.com
