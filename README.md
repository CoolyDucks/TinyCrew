
# Tiny Crew Mod 🛸

Tiny Crew is a mod for **Among Us** that makes players **smaller** while keeping HUD, camera, and cosmetics fully aligned and smooth.

---

## ⚡ Features
- Scale down players with a configurable size modifier.
- HUD and camera adjust automatically to the new size.
- Hats, pets, and cosmetics remain proportional.
- Dynamic size changes supported via config.
- Fully compatible with **BepInEx IL2CPP**.

---

## 🛠️ Installation
1. Make sure **BepInEx IL2CPP** is installed in your Among Us folder.
2. Copy `TinyCrewPlugin.dll` into:Among Us/BepInEx/plugins/
3. 3. Launch the game. Players will now appear smaller, with HUD and cosmetics perfectly adjusted.

---

## ⚙️ Configuration
- Open the config file generated in `BepInEx/config/TinyCrewPlugin.cfg`.
- Change `GlobalModifier` to adjust the size (default is `2.0` → half the normal size).

---

## 📌 Notes
- This mod is client-side only.
- Works with the latest Among Us version.
- Designed for smooth visuals and gameplay.

---

## 📦 Build
- Open `TinyCrew.sln` in Visual Studio.
- Build `Release` to generate the DLL.
- Optionally use `build.cake` for automated builds.
