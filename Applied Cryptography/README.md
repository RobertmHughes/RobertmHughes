# 🔐 Applied Cryptography

> Academic project - BSc Cyber Security, Manchester Metropolitan University  
> **Tool:** Python · Jupyter Notebook · SymPy

A hands-on applied cryptography notebook implementing core number theory algorithms and a full walkthrough of the Data Encryption Standard (DES) from scratch. Every step is coded, explained, and verified - no black-box library calls.

---

## 📖 How to view this project

**Option 1 - View in browser (recommended):**  
Open `RobertHughes_Report.html` directly in any browser - no setup needed. All code, outputs, and written explanations are fully rendered.

**Option 2 - Run interactively:**  
Open `RobertHughes_Report.ipynb` in Jupyter Notebook or JupyterLab to run and modify the code yourself.

```bash
pip install jupyter sympy
jupyter notebook RobertHughes_Report.ipynb
```

---

## 📋 Contents

### Part 1 - Number Theory

| Question | Topic | Description |
|----------|-------|-------------|
| NT.01 | Euclidean Algorithm | Custom `mygcd()` implementation - calculates GCD step-by-step with full working shown |
| NT.02 | Prime Factorisation | Uses SymPy to find prime factors of `a` and `b`, verifying the GCD result |
| NT.03 | Extended Euclidean Algorithm | Custom `mygcdex()` - finds integer coefficients `x`, `y` satisfying `gcd(a,b) = xa + yb` |
| NT.04 | Coefficient Pair Generation | Generates 10 distinct Bézout coefficient pairs by iterating on the inputs |
| NT.05 | Fermat's Little Theorem | Calculates `3^n mod p` using Fermat's theorem, verified with manual working |
| NT.06 | Repeated Squaring | Calculates `5^n mod p` using the method of repeated squaring, with binary ID breakdown |

All inputs are derived from the student ID `21396682`, split into `a = 2139` and `b = 6682`.

---

### Part 2 - Data Encryption Standard (DES)

A complete step-by-step implementation of one round of DES encryption, built from scratch using Python:

| Question | Step | Description |
|----------|------|-------------|
| Q1 | ASCII → Binary | Converts the 8-digit student ID into a 64-bit binary message `m` |
| Q2 | Initial Permutation | Applies the IP table to produce `IPm`, verified manually |
| Q3 | L0 / R0 Split | Splits `IPm` into two 32-bit halves |
| Q4 | Expansion Permutation | Expands `R0` from 32 to 48 bits using the E table to produce `ER0` |
| Q5 | Subkey K1 Generation | Full key schedule step - PC1 permutation → C0/D0 split → left rotation → PC2 permutation → `K1` |
| Q6 | XOR Operation | XORs `ER0` and `K1` to produce intermediate value `A` |
| Q7 | S-box Substitution | Applies all 8 S-boxes to compress `A` from 48 back to 32 bits → `SA` |

---

## 🛠️ Tech

`Python` `Jupyter Notebook` `SymPy` `Number Theory` `DES` `Cryptography`

---

## 🔑 Key concepts covered

- Euclidean & Extended Euclidean algorithms
- Prime factorisation and GCD proofs
- Fermat's Little Theorem
- Repeated squaring for modular exponentiation
- DES initial permutation, key scheduling, expansion, XOR, and S-box substitution
- Manual verification of all computed results

---

## 📬 Get in touch

- 💼 [LinkedIn](https://www.linkedin.com/in/robert-hughes)
- 📧 robertmarkhughes2@gmail.com
