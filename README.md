<div align="center">

# Hi, I'm Rob 👋

### Cybersecurity graduate · QA Engineer · Aspiring Security Professional

[![LinkedIn](https://img.shields.io/badge/LinkedIn-Connect-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/robert-hughes-)
[![Email](https://img.shields.io/badge/Email-Get_in_touch-EA4335?style=for-the-badge&logo=gmail&logoColor=white)](mailto:robertmarkhughes2@gmail.com)
![Location](https://img.shields.io/badge/Manchester-UK-informational?style=for-the-badge)
![Status](https://img.shields.io/badge/Open_to-Cyber_Security_Roles-brightgreen?style=for-the-badge)

</div>

---

I'm a BSc Cyber Security (First-Class Honours) graduate from Manchester Metropolitan University, currently working as a QA Engineer on financial software. My day-to-day covers manual, automated, and security testing, and more recently AI quality and security assurance.

This repo is a showcase of my university work, professional-style projects, and side builds.

|  |  |
|---|---|
| 🎓 **Education** | BSc Cyber Security, First-Class Honours, Manchester Metropolitan University |
| 💼 **Currently** | QA Engineer (manual, automated and security testing, AI assurance) |
| 🎯 **Looking for** | Cyber security roles |
| 📍 **Location** | Manchester, UK |
---

## ⭐ Featured Project

### AI QA Test Harness: LLM Quality & Security Assurance

> An in-house test harness I designed and built to assess AI-powered applications for security, quality, consistency and accuracy, acting as a decision-making layer between the system under test and the people responsible for it.

Testing LLM-backed features is different from testing deterministic software: the same input can produce different outputs, and "correct" is often a judgement call. I built the harness to make that measurable and repeatable.

**How it works**

```mermaid
flowchart LR
    P[Prompter Node<br/>generates test inputs] --> A[Application<br/>under test]
    A --> V[Validator Node<br/>rule and schema checks]
    V --> J[LLM-as-a-Judge<br/>scores quality and correctness]
    J --> D{Decision Layer}
    D --> R[Reports and Tracking<br/>quality, consistency, budget]
    D --> U[User Node<br/>feedback and review]
    U -.refines.-> P
```

**What it covers**

| Area | What the harness does |
|---|---|
| **AI security** | Adversarial and misuse-style prompts to probe for unsafe or unintended behaviour |
| **Accuracy & incorrectness** | Detects wrong, hallucinated or off-spec responses |
| **Consistency** | Repeated runs to measure response stability across the same inputs |
| **Test data generation** | Automatically generates varied, targeted test data per application |
| **LLM-as-a-judge** | Automated scoring against defined criteria, with human feedback loop |
| **Budget & usage tracking** | Tracks token usage and cost per run so quality can be weighed against spend |
| **Reporting** | Quality, consistency and tracking information fed back to users |

**Highlights**
- Designed as a modular, node-based architecture (prompter, validator, judge, user), so each stage can be configured per application
- Built and adopted across multiple applications, adapting to each one's needs
- Has its own dedicated test coverage, because a test tool should be tested too
- Results: Detected significant consistency issues, raised with Production, and validated the fixes to bring the AI to a 95% consistency range.

`AI Harness` `LLM-as-a-Judge` `Test Automation` `AI Security` `Prompt Testing` `Test Data Generation`

> _Built for an employer, so implementation details are kept high-level here. Happy to talk through the design in more depth._

---

## More Projects

<details>
<summary><b>SMS Fraud Detection: ML Dissertation (First-Class)</b></summary>

<br>

Final-year dissertation: a machine learning model that detects SMS-based fraud (smishing). Covers data preprocessing, feature engineering, model training and evaluation.

- **Result:** 95% Precision
- **Models compared:** Naïve Bayes Classifier & Fast Forest OVA

`Python` `scikit-learn` `NLP` `Classification`
<br>
[Go to Repo](./ML-SMS-Fraud-Detection)
</details>

<details>
<summary><b>Network Design & Implementation</b></summary>

<br>

Full network design for a 50-employee organisation across two floors, built and verified in Cisco Packet Tracer.

- CIDR addressing and subnetting
- SSH hardening, DHCP, RIP routing
- Redundancy and full connectivity testing

`Cisco Packet Tracer` `SSH` `DHCP` `RIP` `CIDR` `Cisco IOS`
<br>
[Go to Repo](./Network%20Design%20%26%20Implementation)
</details>

<details>
<summary><b>Applied Cryptography</b></summary>

<br>

Core cryptographic concepts implemented from scratch in Python: Euclidean and Extended Euclidean algorithms, Fermat's Little Theorem, repeated squaring, and a full walkthrough of one round of DES.

`Python` `Jupyter Notebook` `SymPy` `Number Theory` `DES`
<br>
[Go to Repo](./Applied-Cryptography)
</details>

<details>
<summary><b>Chrome Productivity Extensions</b></summary>

<br>

Browser extensions I built to solve my own time-management problems, a practical way to keep developing my programming skills outside of work.

`JavaScript` `HTML` `Chrome APIs` `Manifest V3`
<br>
[Go to Repo](./Chrome-Extension-Projects)
</details>

---

## Tools & Languages

**Languages**

![Python](https://img.shields.io/badge/Python-3776AB?style=flat-square&logo=python&logoColor=white)
![C#](https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=csharp&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=flat-square&logo=javascript&logoColor=black)
![SQL](https://img.shields.io/badge/SQL-4479A1?style=flat-square&logo=postgresql&logoColor=white)

**Security**

![Burp Suite](https://img.shields.io/badge/Burp_Suite-FF6633?style=flat-square&logo=burpsuite&logoColor=white)
![Wireshark](https://img.shields.io/badge/Wireshark-1679A7?style=flat-square&logo=wireshark&logoColor=white)
![Elastic](https://img.shields.io/badge/Elastic-005571?style=flat-square&logo=elastic&logoColor=white)
![Cisco](https://img.shields.io/badge/Cisco_Packet_Tracer-1BA0D7?style=flat-square&logo=cisco&logoColor=white)

**QA & Dev**

![Postman](https://img.shields.io/badge/Postman-FF6C37?style=flat-square&logo=postman&logoColor=white)
![JMeter](https://img.shields.io/badge/JMeter-D22128?style=flat-square&logo=apachejmeter&logoColor=white)
![Argo CD](https://img.shields.io/badge/Argo_CD-EF7B4D?style=flat-square&logo=argo&logoColor=white)
![VMware](https://img.shields.io/badge/VMware-607078?style=flat-square&logo=vmware&logoColor=white)
![Oracle](https://img.shields.io/badge/Oracle-F80000?style=flat-square&logo=oracle&logoColor=white)

---

<div align="center">

### Get in touch 👋

If you're hiring for a security role or just want to chat about security, testing, and AI, I'd love to hear from you.

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/robert-hughes-)
[![Email](https://img.shields.io/badge/Email-EA4335?style=for-the-badge&logo=gmail&logoColor=white)](mailto:robertmarkhughes2@gmail.com)

</div>
