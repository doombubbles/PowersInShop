# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [3.1.1] - 2026-06-03

- Updated for BTD6 v55

## [3.1.0] - 2026-04-09

- Minor fix for v54
- Added Hype Boost Monkey and Tech Bot Prime to Shop
  - Standard rules apply for needing to have already unlocked the real Powers Pro in order to use

## [3.0.5] - 2025-12-03

- Minor fix for v52

## [3.0.4] - 2025-09-26

- Fixed Energising Totem and Super Monkey Beacon recharge buttons for v50.2
- Fixed some interactions with Copy/Pasting Powers Pro purchased from the shop

## [3.0.3] - 2025-08-31

- Fixed the Allow in Chimps settings
- Fixed a potential error when the internal Chimps mutator would modify the game model

## [3.0.2] - 2025-08-30

- Fixed a console error that occasionally showed up about mutators

## [3.0.1] - 2025-08-29

- Fixed issue with the Beacon Recharge Button not always showing
- Updated support for Ultimate Crosspathing

## [3.0.0] - 2025-08-29

- Added Powers Pro to Shop
    - Banana Farmer Pro (\$1000)
    - Super Monkey Beacon (\$4000)
    - You still have to unlock Powers Pro and their upgrades normally to be able to buy them from the shop
- Some power default costs have been changed to reflect the costs established for the powers within Rogue Legends /
  changes the powers have received
    - Pontoon -> \$450
    - Portable Lake -> \$500
    - Tech Bot -> \$375
    - Glue Trap -> \$500
    - Camo Trap -> \$600
    - Moab Mine -> \$2000 (Pierce still modified to 1 by default)
- Added the Cave Monkey to the shop, with a cost of \$750
- Implemented most of the remaining powers, but due to the inherit imbalance of having them in the shop, they are all
  disabled by default via having their costs set to -1 in settings. To use them in game you will need to change this to
  whatever you deem is an appropriate cost.
    - Super Monkey Storm
    - Monkey Boost
    - Thrive
    - Time Stop

## [2.1.11] - 2025-08-27

- Fixed for BTD6 v50, shop versions of the new pro powers will be added in a subsequent update

## [2.1.10] - 2025-06-18

- Fixed for BTD6 v49

## [2.1.9] - 2025-02-04

- Fixed for BTD6 v47
- Fixed bug where Moneky Knowledge wouldn't properly apply to some power towers

## [2.1.8] - 2024-12-14

- Fixed placement logic for track powers to let them be properly placed on the new map

## [2.1.7] - 2024-12-12

- Fixed for BTD6 v46

## [2.1.6] - 2024-10-09

- Fixed for BTD6 v45

## [2.1.5] - 2024-08-25

- Changing Power Tower costs no longer requires a Restart to take effect
- Modes like Odysseys which limit your power inventory now also apply to powers in shop
- Power Towers will no longer be part of Monkey Teams

## [2.1.4] - 2024-06-19

- Tech Bot tower can no longer target itself and cause crashes

## [2.1.3] - 2024-05-29

- Fixed for BTD6 v43

## [2.1.2] - 2024-04-08

- Fixed for BTD6 v42

## [2.1.1] - 2024-02-07

- Fixed for BTD6 v41

## [2.1.0] - 2023-10-14

- Fixed for BTD6 v39
- Added options for applying power skins to powers in shop
- Added option to override normal Power Hotkeys to use for the powers in shop
- Fixed Monkey Knowledge not applying properly to powers in shop
- Fixed bugs with Energising Totem UI
- Benjamin's Biohack now ignores the powers in shop towers

## [2.0.6] - 2023-04-04

- Fixed for BTD6 v36.0

## [2.0.5] - 2022-12-27

- Updated for Melon Loader 0.6.0

Due to v34 breakage, Power Towers won't be back to appearing in the Monkeys Screen until a later date

## [2.0.4] - 2022-10-20

- Fixed for BTD6 v33.0

## [2.0.3] - 2022-08-08

- Fixed for BTD6 v32.0

## [2.0.2] - 2022-07-24

- Update for Mod Helper 3.0 alpha

[unreleased]: https://github.com/doombubbles/PowersInShop/compare/3.1.1...HEAD
[3.1.1]: https://github.com/doombubbles/PowersInShop/compare/3.1.0...3.1.1
[3.1.0]: https://github.com/doombubbles/PowersInShop/compare/3.0.5...3.1.0
[3.0.5]: https://github.com/doombubbles/PowersInShop/compare/3.0.4...3.0.5
[3.0.4]: https://github.com/doombubbles/PowersInShop/compare/3.0.3...3.0.4
[3.0.3]: https://github.com/doombubbles/PowersInShop/compare/3.0.2...3.0.3
[3.0.2]: https://github.com/doombubbles/PowersInShop/compare/3.0.1...3.0.2
[3.0.1]: https://github.com/doombubbles/PowersInShop/compare/3.0.0...3.0.1
[3.0.0]: https://github.com/doombubbles/PowersInShop/compare/2.1.11...3.0.0
[2.1.11]: https://github.com/doombubbles/PowersInShop/compare/2.1.10...2.1.11
[2.1.10]: https://github.com/doombubbles/PowersInShop/compare/2.1.9...2.1.10
[2.1.9]: https://github.com/doombubbles/PowersInShop/compare/2.1.8...2.1.9
[2.1.8]: https://github.com/doombubbles/PowersInShop/compare/2.1.7...2.1.8
[2.1.7]: https://github.com/doombubbles/PowersInShop/compare/2.1.6...2.1.7
[2.1.6]: https://github.com/doombubbles/PowersInShop/compare/2.1.5...2.1.6
[2.1.5]: https://github.com/doombubbles/PowersInShop/compare/2.1.4...2.1.5
[2.1.4]: https://github.com/doombubbles/PowersInShop/compare/2.1.3...2.1.4
[2.1.3]: https://github.com/doombubbles/PowersInShop/compare/2.1.2...2.1.3
[2.1.2]: https://github.com/doombubbles/PowersInShop/compare/2.1.1...2.1.2
[2.1.1]: https://github.com/doombubbles/PowersInShop/compare/2.1.0...2.1.1
[2.1.0]: https://github.com/doombubbles/PowersInShop/compare/2.0.6...2.1.0
[2.0.6]: https://github.com/doombubbles/PowersInShop/compare/2.0.5...2.0.6
[2.0.5]: https://github.com/doombubbles/PowersInShop/compare/2.0.4...2.0.5
[2.0.4]: https://github.com/doombubbles/PowersInShop/compare/2.0.3...2.0.4
[2.0.3]: https://github.com/doombubbles/PowersInShop/compare/2.0.2...2.0.3
[2.0.2]: https://github.com/doombubbles/PowersInShop/compare/3645a8f2a62a3dcd28015b048e238f6d0bec4619...2.0.2
