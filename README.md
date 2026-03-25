<div align="center">

<img src="https://img.shields.io/badge/C%23-.NET%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
<img src="https://img.shields.io/badge/Windows%20Forms-WinForms-0078D4?style=for-the-badge&logo=windows&logoColor=white" />
<img src="https://img.shields.io/badge/Windows%20Media%20Player-WMP-00ADEF?style=for-the-badge&logo=windows&logoColor=white" />
<img src="https://img.shields.io/badge/platform-Windows-0078D4?style=for-the-badge" />
<img src="https://img.shields.io/badge/status-in%20development-yellow?style=for-the-badge" />

<br/>
<br/>

# 🎵 DRYLOUD — Desktop Music Player

**A Windows desktop music player with user authentication, playlist management and file search.**  
Built with C# and Windows Forms as a school project focused on desktop application development.

> ⚠️ **Note:** The source code, UI labels, comments and variable names are written in **Portuguese (pt-BR)**, as this project was developed for a Portuguese school assignment.

[Features](#-features) • [How It Works](#-how-it-works) • [Tech Stack](#-tech-stack) • [Getting Started](#-getting-started) • [Project Structure](#-project-structure)

</div>

---

## 🧩 About the Project

DRYLOUD is a desktop music player built entirely with Windows Forms and the Windows Media Player ActiveX component.

The application features a full authentication system — users can register and log in before accessing the player. Passwords are never stored in plain text; they are hashed using **PBKDF2 with SHA-256** and a random salt, making the credential system secure by design.

After login, the user has access to a complete music player with playlist support and track search.

---

## ✨ Features

- 🔐 **Secure authentication** — register and login with PBKDF2-SHA256 hashed passwords + random salt
- 👤 **User registration** — creates an account stored locally in a JSON file
- 🎵 **Music playback** — play, stop and select audio files (MP3, WAV, WMA, AAC)
- ➕ **Add tracks** — import multiple audio files to the player queue
- 🔍 **Track search** — search for songs by filename within the loaded list
- 📋 **Playlist management** — create, add, remove and play tracks from a dedicated playlist screen
- 🔓 **Logout** — return to the home screen and switch accounts

---

## ⚡ How It Works

```
App starts → Home screen (Form1)
                  ↓
         Login (Form2) ←→ Register (Form3)
                  ↓
         Music Player (Form4)
           ↙           ↘
    Add tracks        Playlist (Form6)
    Search songs      Add / Remove / Play
```

Credentials are saved to:
```
%AppData%\WinFormsApp2\users.json
```

Each entry stores: `username`, `passwordHash` (PBKDF2-SHA256), and `salt` (random 16 bytes).

---

## 🛠 Tech Stack

| Technology | Purpose |
|---|---|
| [C# / .NET 8](https://dotnet.microsoft.com/) | Application language and runtime |
| [Windows Forms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/) | Desktop UI framework |
| [Windows Media Player (ActiveX)](https://learn.microsoft.com/en-us/windows/win32/wmp/windows-media-player-sdk) | Audio playback engine |
| `System.Security.Cryptography` | PBKDF2 password hashing |
| `System.Text.Json` | JSON serialization for user storage |

---

## 📦 Prerequisites

- **Windows** (required — Windows Forms + WMP are Windows-only)
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET Desktop Development** workload
- Windows Media Player enabled on your system

---

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/EduhxH/dryloud.git
cd dryloud
```

### 2. Open in Visual Studio

Open the `WinFormsApp6.sln` file in Visual Studio 2022.

### 3. Restore and build

```bash
dotnet restore
dotnet build
```

Or simply press **F5** inside Visual Studio to build and run.

> ✅ The app will launch directly to the home screen.

---

## 🖥 Screens

| Screen | Description |
|---|---|
| **Form1** — Home | Entry point with Login and Register buttons |
| **Form2** — Login | Authenticates the user with hashed password verification |
| **Form3** — Register | Creates a new account with password confirmation |
| **Form4** — Player | Main music player with track list, search and controls |
| **Form6** — Playlist | Dedicated playlist screen with add, remove and playback |

---

## 📁 Project Structure

```
DRYLOUD2/
│
└── WinFormsApp6/
    ├── Form1.cs / .Designer.cs       # Home screen
    ├── Form2.cs / .Designer.cs       # Login screen
    ├── Form3.cs / .Designer.cs       # Register screen
    ├── Form4.cs / .Designer.cs       # Music player
    ├── Form5.cs / .Designer.cs       # (auxiliary)
    ├── Form6.cs / .Designer.cs       # Playlist screen
    ├── Program.cs                    # App entry point
    ├── Properties/
    │   └── Resources.Designer.cs     # Embedded resources
    ├── Resources/                    # Images and assets
    └── WinFormsApp6.csproj           # Project file
```

---

## 🧠 What I Learned

- Building multi-form desktop applications with Windows Forms
- Implementing secure password storage with PBKDF2 + random salt
- Integrating the Windows Media Player ActiveX component for audio playback
- Persisting user data locally using JSON serialization
- Managing navigation flow across multiple forms in a WinForms app

---

## 🔮 Future Improvements

- [ ] Audio converter (MP3 export)
- [ ] Persistent playlist saved to disk
- [ ] Skip to next / previous track
- [ ] Volume and progress bar controls
- [ ] Dark mode UI

---

<div align="center">

Made with 💜 by [EduhxH](https://github.com/EduhxH)

</div>
