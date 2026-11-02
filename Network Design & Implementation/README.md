# 🌐 Network Design & Implementation
<img width="1907" height="523" alt="image" src="https://github.com/user-attachments/assets/05258652-2911-4e06-953f-21580908ee5d" />

> Academic project - BSc Cyber Security, Manchester Metropolitan University  
> **Tool:** Cisco Packet Tracer

A full network design and implementation project for a medium-sized organisation requiring connectivity for ~50 employees across two floors. The project covers everything from initial design and IP addressing through to full configuration, protocol verification, and evaluation.

---

## 📋 Project overview

The brief was to design, configure, and verify a scalable, secure, and redundant network for an advertising client needing access for around 50 employees across two floors. The network had to support both wired and wireless connections, with efficient IP management and remote administration capability.

---

## 🏗️ Network design

The network consists of two floors, each with:
- **1 router** per floor, interconnected for cross-floor communication
- **1 Cisco 2960 switch** per floor (supports up to 24 wired devices, allowing room for future growth)
- **1 wireless access point** per floor for mobile devices (laptops, tablets, smartphones)
- **Copper straight-through cables** throughout - the recommended choice for PC-to-switch and switch-to-router connections

**Redundancy** was built in by connecting both floors' switches directly - so if one router goes offline, the devices can still communicate across the network.

| Floor | Wired devices | Wireless devices |
|-------|--------------|-----------------|
| Floor 1 | 20 PCs | Laptops, tablets, smartphones |
| Floor 2 | 20 PCs | Laptops, tablets, smartphones |
| **Total** | **40 wired** | **Wireless via AP on each floor** |

---

## ⚙️ Configuration

### SSH - Secure Shell
SSH was configured on both routers to allow secure remote management. This enables administrators to run shell commands on the routers without needing physical access - improving security, reducing management overhead, and lowering costs.

### DHCP - Dynamic Host Configuration Protocol
DHCP was configured on both routers and switches to automatically assign IP addresses to all devices on the network. This eliminates manual IP configuration errors (such as duplicate addresses) and simplifies network management. The DHCP pool defines the IP range, default gateway, and DNS server for each floor.

### RIP - Routing Information Protocol
RIP was implemented across both routers to provide dynamic routing between floors. Each router maintains a routing table so packets always find the most efficient path to their destination. The FastEthernet interfaces on both routers were added to the RIP configuration, enabling inter-floor communication.

### CIDR - Classless Inter-Domain Routing
A CIDR IP addressing scheme was applied to divide the address space into efficient subnets across both floors. This avoids wasting IP addresses and future-proofs the network - if the organisation grows beyond 256 devices, CIDR means the infrastructure is already in place without requiring a full reconfiguration.

---

## ✅ Network verification

All configurations were tested and verified using Cisco Packet Tracer's simulation tools:

| Test | Result |
|------|--------|
| PC-to-PC ping (same floor) | ✅ Successful |
| PC-to-PC ping (cross-floor) | ✅ Successful |
| Router-to-router communication | ✅ Successful |
| Switch-to-wireless access point | ✅ Successful |
| Wired-to-wireless device ping (PC9 → Laptop3) | ✅ Successful |
| RIP verification (`show ip route`) | ✅ RIP routes confirmed on R1 & R2 |
| DHCP verification (`show ip dhcp binding`) | ✅ All devices assigned IPs automatically |

---

## 🔒 Security considerations

- **SSH** configured on all routers to prevent unauthorised remote access
- **Login credentials** required to access network devices via shell
- **Least privilege access** recommended across all network devices to minimise the attack surface

---

## 📊 Evaluation

**Strengths:**
- Scalable design - 2960 switches have spare ports for future devices
- Redundant switch connections protect against router failures
- DHCP, RIP, and CIDR all contribute to a low-maintenance, high-performance network
- Wireless access on every floor accommodates a variety of device types

**Limitations:**
- High upfront hardware cost
- Complexity requires skilled staff to manage and maintain
- Mitigated by the potential for network monitoring and automation tools to reduce ongoing workload

---

## 🛠️ Tools & protocols

`Cisco Packet Tracer` `SSH` `DHCP` `RIP` `CIDR` `TCP/IP` `Cisco IOS`

---

## 📬 Get in touch

- 💼 [LinkedIn](https://www.linkedin.com/in/robert-hughes)
- 📧 robertmarkhughes2@gmail.com
