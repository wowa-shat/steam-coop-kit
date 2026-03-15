![License](https://img.shields.io/badge/license-MIT-green)
![Unity](https://img.shields.io/badge/unity-6-black)
![Steamworks](https://img.shields.io/badge/steamworks-supported-blue)
![Status](https://img.shields.io/badge/status-in%20development-orange)

# SteamCoopKit

A lightweight open-source framework for building Steam-based co-op games in Unity.

It provides ready-to-use systems for Steam lobbies, friend invites and P2P multiplayer sessions, allowing developers to quickly build small co-op games with friends.

## Quick Start

1. Clone the repository
2. Open the project in Unity
3. Add your Steam App ID (or use default ***480***)
4. Run the sample scene
5. Create a lobby and invite friends

## Planned Features

- Steam names and avatars  
- Steam lobby system  
- Friend invites via Steam overlay  
- P2P multiplayer sessions  
- Ready system for cooperative matches

## Roadmap

### MVP
- [ ] Steam names and avatars
- [ ] Steam lobby system
- [ ] Friend invites via Steam overlay
- [ ] P2P multiplayer sessions
- [ ] Ready system for starting matches
- [ ] Lobby → Game → Lobby session flow
- [ ] Multiplayer sample scene

### Extra
- [ ] Lobby browser
- [ ] Host migration
- [ ] Voice chat

## Steam Integration

SteamCoopKit uses [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET) as a C# wrapper for the [Steamworks SDK](https://partner.steamgames.com/doc/sdk).

All Steam-specific functionality is isolated behind a service layer, allowing the framework to remain modular and extensible.

## License

MIT License