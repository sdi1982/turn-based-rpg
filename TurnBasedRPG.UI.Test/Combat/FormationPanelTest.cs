﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedRPG.Model.Entities;
using TurnBasedRPG.Shared.Interfaces;
using TurnBasedRPG.UI.Combat.Panels;

namespace TurnBasedRPG.UI.Test.Combat
{
    [TestClass]
    public class FormationPanelTest
    {
        [TestMethod]
        public void Render_WithPositionsOneTwoFour_RendersSymbols()
        {
            var formationPanel = new FormationPanel();
            int focusId = 1;
            var blankTargets = new List<int>();
            var data = new List<IDisplayCharacter>()
            {
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'A',
                    Position = 1,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                },
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'B',
                    Position = 2,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                },
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'C',
                    Position = 4,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                },
            };
            var expected = new List<string>()
            {
                "\n\n\n",
                "                                                                                                                   ",
                "          │■■■■■│        │■■■■■│                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │A│            │B│            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "          │■■■■■│                                                                                             \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │C│            │ │            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                                                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n"
            };

            var actual = new List<string>(formationPanel.Render(data, focusId, blankTargets));

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Render_WithPositionsSixNineElevenFourteen_RendersSymbols()
        {
            var formationPanel = new FormationPanel();
            int focusId = 1;
            var blankTargets = new List<int>();
            var data = new List<IDisplayCharacter>()
            {
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'A',
                    Position = 6,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                },
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'B',
                    Position = 9,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                },
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'C',
                    Position = 11,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                },
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'D',
                    Position = 14,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                }
            };
            var expected = new List<string>()
            {
                "\n\n\n",
                "                                                                                                                   ",
                "                                                                                        │■■■■■│               \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │ │                              │ │            │C│            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                                        │■■■■■│                                         │■■■■■│               \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │A│                              │ │            │D│            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                                        │■■■■■│                                                               \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │B│                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n"
            };

            var actual = new List<string>(formationPanel.Render(data, focusId, blankTargets));

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Render_WithPositionsTwoFive_RendersNames()
        {
            var formationPanel = new FormationPanel();
            int focusId = 1;
            var blankTargets = new List<int>();
            var data = new List<IDisplayCharacter>()
            {
                new Character()
                {
                    Id = 0,
                    Name = "Anderson",
                    Symbol = 'A',
                    Position = 2,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                },
                new Character()
                {
                    Id = 0,
                    Name = "Brock",
                    Symbol = 'B',
                    Position = 5,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                }
            };
            var expected = new List<string>()
            {
                "\n\n\n",
                "                         Anderson                                                                                  ",
                "                         │■■■■■│                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │A│            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                          Brock                                                                                    ",
                "                         │■■■■■│                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │B│            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                                                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n"
            };

            var actual = new List<string>(formationPanel.Render(data, focusId, blankTargets));

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Render_WithPositionsTwoFiveAndDamaged_RendersHealthbars()
        {
            var formationPanel = new FormationPanel();
            int focusId = 1;
            var blankTargets = new List<int>();
            var data = new List<IDisplayCharacter>()
            {
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'A',
                    Position = 2,
                    CurrentHealth = 90,
                    CurrentMaxHealth = 100
                },
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'B',
                    Position = 5,
                    CurrentHealth = 15,
                    CurrentMaxHealth = 100
                }
            };
            var expected = new List<string>()
            {
                "\n\n\n",
                "                                                                                                                   ",
                "                         │■■■■ │                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │A│            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                         │■    │                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │B│            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                                                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n"
            };

            var actual = new List<string>(formationPanel.Render(data, focusId, blankTargets));

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Render_WithPositionsTwoFiveAndDead_RendersDead()
        {
            var formationPanel = new FormationPanel();
            int focusId = 1;
            var blankTargets = new List<int>();
            var data = new List<IDisplayCharacter>()
            {
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'A',
                    Position = 2,
                    CurrentHealth = 0,
                    CurrentMaxHealth = 100
                },
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'B',
                    Position = 5,
                    CurrentHealth = 0,
                    CurrentMaxHealth = 100
                }
            };
            var expected = new List<string>()
            {
                "\n\n\n",
                "                                                                                                                   ",
                "                         │     │                                                                              \n",
                "            ┌─┐            \\ /            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │             A             │ │                              │ │            │ │            │ │",
                "            └─┘            / \\            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                         │     │                                                                              \n",
                "            ┌─┐            \\ /            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │             B             │ │                              │ │            │ │            │ │",
                "            └─┘            / \\            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                                                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n"
            };

            var actual = new List<string>(formationPanel.Render(data, focusId, blankTargets));

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Render_WithPositionsTwoFiveAndActiveId_RendersActiveBox()
        {
            var formationPanel = new FormationPanel();
            int focusId = 1;
            var blankTargets = new List<int>();
            var data = new List<IDisplayCharacter>()
            {
                new Character()
                {
                    Id = 1,
                    Name = "",
                    Symbol = 'A',
                    Position = 2,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                },
                new Character()
                {
                    Id = 0,
                    Name = "",
                    Symbol = 'B',
                    Position = 5,
                    CurrentHealth = 100,
                    CurrentMaxHealth = 100
                }
            };
            var expected = new List<string>()
            {
                "\n\n\n",
                "                                                                                                                   ",
                "                         │■■■■■│                                                                              \n",
                "            ┌─┐            ╔═╗            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            ║A║            │ │                              │ │            │ │            │ │",
                "            └─┘            ╚═╝            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                         │■■■■■│                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │B│            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n",
                "                                                                                                                   ",
                "                                                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "",
                "\n"
            };

            var actual = new List<string>(formationPanel.Render(data, focusId, blankTargets));

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Render_WithTargets_RendersTargets()
        {
            var formationPanel = new FormationPanel();
            formationPanel.RenderFocus = true;
            var targets = new List<int>() { 2, 4, 5, 6, 8 };
            int focusId = 1;
            var data = new List<IDisplayCharacter>();
            var expected = new List<string>()
            {
                "\n\n\n",
                "                                                                                                                   ",
                "                                                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "                            ▲                                                                              ",
                "\n",
                "                                                                                                                   ",
                "                                                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "             ▲              ▲              ▲                                                               ",
                "\n",
                "                                                                                                                   ",
                "                                                                                                              \n",
                "            ┌─┐            ┌─┐            ┌─┐                              ┌─┐            ┌─┐            ┌─┐",
                "            │ │            │ │            │ │                              │ │            │ │            │ │",
                "            └─┘            └─┘            └─┘                              └─┘            └─┘            └─┘",
                "                            ▲                                                                              ",
                "\n"
            };

            var actual = new List<string>(formationPanel.Render(data, focusId, targets));

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
