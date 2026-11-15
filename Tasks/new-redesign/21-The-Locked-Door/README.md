<img src="../../../assets/door-key.gif" align="right" width="96" alt="The Locked Door" />

<div align="center">

# 🚪 21 - Boss Battle: The Locked Door

### Encapsulated `Door` state machine enforcing valid state transitions and passcode-verified locking/unlocking.

![Level](https://img.shields.io/badge/Level-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-State%20Machine%20%26%20Encapsulation-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Boss Battle: The Locked Door — 100 XP)

**Level 24 — The Catacombs of the Class (Fourth Pedestal):**
The fourth pedestal demands constructing a `Door` class with a passcode-protected locking mechanism governed by these rules:

- An open door can always be closed (`Open ➔ Closed`).
- A closed (but unlocked) door can always be opened (`Closed ➔ Open`).
- A closed door can always be locked (`Closed ➔ Locked`).
- A locked door can only be unlocked (`Locked ➔ Closed`) when the supplied passcode matches the door's current passcode.
- When a door is created, it must be initialized with a starting passcode.
- The passcode can be changed by providing both the current passcode and the new passcode; it updates only if the current passcode is correct.

### Objectives:
- Define a `Door` class that tracks whether it is `Locked`, `Open`, or `Closed`.
- Support the four state transitions above via methods.
- Build a constructor that requires an initial passcode.
- Build a method to change the passcode by supplying the current and new passcodes.
- In `Main`, ask the user for a starting passcode, create a `Door` instance, and run a command loop allowing the user to transition states and change the passcode.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

### 1. Information Hiding (`private string Password`) & State Modeling
- Modeled the door states with `DoorStateEnum` (`Open`, `Closed`, `Locked`) and exposed `DoorState` as read-only (`public DoorStateEnum DoorState { get; private set; }`).
- Kept the passcode strictly hidden inside `private string Password { get; set; }` so external callers cannot inspect or overwrite it directly.

### 2. Guarded State Transitions & Passcode Rotation
To prevent illegal transitions (such as opening a locked door directly or locking an open door without closing it first), each transition validates the current state:
- **`openDoor()`:** Transitions to `Open` only when `DoorState == DoorStateEnum.Closed`; if locked, informs the user that the door must be unlocked first.
- **`closeDooor()`:** Transitions to `Closed` only when `DoorState == DoorStateEnum.Open`.
- **`lockDoor(string password)` & `unlockDoor(string password)`:** Verify both the door's current state and `password == Password` before changing states.
- **`changePassword(string oldPassword, string newPassword)`:** Updates `Password` only when `oldPassword == Password`, rejecting unauthorized changes.

---

## 📁 Files

- [`Program.cs`](Program.cs) — `Door` class, `DoorStateEnum`, and interactive command loop (`LevelTask.Task21.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 20 - The Card](../20-The-Card/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [22 - The Password Validator ➡️](../22-The-Password-Validator/README.md)

</div>
