# 🏠 CRASHOUT

> A VR destruction game where you use a bazooka to demolish buildings, score points, and race against the clock.

## 🎮 Gameplay

https://github.com/user-attachments/assets/8526b6b7-15f8-486b-ba41-a71258b77442

> 🎬 **Backup video:** [`Video/Gameplay.mp4`](Video/Gameplay.mp4) — jika player di atas tidak muncul, buka video langsung di folder repo.

*Built with Unity 2022.3 LTS + XR Interaction Toolkit*

---

## ✨ Features

- 🏚️ **Destructible Buildings** — Real-time fracture physics using OpenFracture
- 🚀 **Bazooka Weapon** — Grab, aim, and fire rockets with XR Interaction Toolkit
- 🎯 **Scoring System** — Earn points for every object destroyed
- ⏱️ **Timed Rounds** — Race against the clock before time runs out
- 🎵 **Sound Effects** — Explosions, glass shattering, wood/metal breaking
- 🌲 **Procedural Tree Spawning** — Dynamic tree placement across the terrain
- 🎛️ **Settings Menu** — Adjustable music and SFX volume
- 🖥️ **MockHMD Support** — Test in Unity Editor without a VR headset

---

## 🛠️ Built With

- **Unity 2022.3.62f3** (LTS)
- **XR Interaction Toolkit 2.6.5** — VR grab, interact, and locomotion
- **OpenFracture** — Runtime mesh destruction
- **MockHMD** — Desktop VR simulation
- **TextMeshPro** — UI text rendering

---

## 🚀 How to Play

1. **Download** the Windows build from [Releases](../../releases)
2. **Extract** the ZIP file
3. **Run** `CRASHOUT.exe`
4. **Grab** the bazooka with your VR controller (or left mouse click in MockHMD)
5. **Shoot** buildings and earn points before time runs out!

---

## 📁 Project Structure

```
CRASHOUT/
├── Assets/
│   ├── Audios/              — Music and sound effects
│   ├── Bazooka/             — Bazooka weapon model
│   ├── Bomb/                — Bomb projectile model
│   ├── FurnishedCabin/      — Cabin building assets
│   ├── Images/              — UI images
│   ├── JMO Assets/          — WarFX particle effects
│   ├── ModularHousePack1/   — Modular house assets
│   ├── Samples/             — XR Interaction Toolkit samples
│   ├── Scenes/              — MainMenu and Map scenes
│   ├── Scripts/             — Game logic (8 scripts)
│   ├── Skybox/              — Skybox materials
│   ├── Trees/               — Tree prefabs
│   ├── XR/                  — XR plugin settings
│   └── XRI/                 — XR Interaction Toolkit settings
├── Build/                   — Windows build
├── Packages/                — Unity package manifest
└── ProjectSettings/         — Unity project settings
```

---

## 🔧 Key Scripts

| Script | Purpose |
|--------|---------|
| `BazookaShoot.cs` | Handles bazooka firing when grabbed via XR |
| `BombScript.cs` | Bomb collision, explosion VFX, and knockback force |
| `GameUIScript.cs` | In-game UI: pause, resume, restart, settings |
| `MainMenuScript.cs` | Main menu navigation and scene loading |
| `ScoreScript.cs` | Score tracking and display |
| `SettingsScript.cs` | Audio mixer volume control with PlayerPrefs |
| `TimerScript.cs` | Countdown timer with game over trigger |
| `TreeSpawner.cs` | Procedural tree placement on terrain |

---

## 📋 Requirements

- **VR Headset** (Meta Quest, HTC Vive, etc.) or **MockHMD** for desktop testing
- **Windows 10+** (for the pre-built release)

---

## 📄 License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

---

## 👤 Author

**CodeMelvin** — [GitHub](https://github.com/CodeMelvin)
