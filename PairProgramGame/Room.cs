using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame
{
    public class Room
    {
        private Player _player;
        public Room(Player potato)
        {
            _player = potato;
        }
        public void Room1()
        {
            Console.WriteLine("Tall grasses and chunks of stone debris have all but overtaken this small yard. Off to one side, a\nwooden stable has collapsed into a mound of rotting timbers and moldy straw.The outer wall on the\neast side has also collapsed, leaving a ragged hole. Two doors exit into this yard—a pair of double\ndoors to the east, and the lone door leading into the squat tower in the south. \n   What do you do? \n 1. Take the East door \n 2. Go back");
            string playerInput = Console.ReadLine();
            switch (playerInput)
            {
                case "1":
                    if (_player.HasKey == true)
                    {
                        Console.WriteLine("Do you want to use the key? \n 1. Yes \n 2. Keep exploring");

                        string playerChoice = Console.ReadLine();
                        switch (playerChoice)
                        {
                            case "1":
                                Console.WriteLine("You use the key to open the door.  Press enter to procede.");
                                Console.ReadLine();
                                Room2();
                                break;
                            case "2":
                                Room1();
                                break;
                            default:
                                Console.WriteLine("Try again.");
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This door is locked, the mechanism looks too complex to pick.");
                        Console.WriteLine("\nPress enter to turn around...");
                        Console.ReadLine();
                        Room1();
                        break;
                    }

                case "2":
                    Room4();
                    break;
                default:
                    Console.WriteLine("Please try again.");
                    Console.ReadLine();
                    Room1();
                    break;
            }
        }
        public void Room2()
        {
            Console.WriteLine("This room is a blood-splattered chamber of horror. Dead rodents, snakes, and birds have been variously\nnailed, tied, and hung around the walls. At the far end of the room, a large cauldron bubbles over an\niron stove set against the north wall, its stovepipe chimney extending up through the ceiling. A bloody\nburlap sack sits on the floor next to the stove. The center of the room contains a long, rickety table\nsurrounded by chairs that contain several grisly decorations—a whole family of skeletal goblins, their\nbones bleached white and bound together by reeds and twine.\n At the head of the table is a man, seated, slurping some sort of soup, absorbed entirely by his soup and zoom call, he does not notice you have entered the room.\n\nWhat do you do? \n 1. Take the East door \n 2. Take the West Door \n 3. Approach the table.");
            string playerInput = Console.ReadLine();
            switch (playerInput)
            {
                case "1":
                    Room3();
                    break;
                case "2":
                    Room1();
                    break;
                case "3":
                    Console.WriteLine("You approach the table, the man seated there suddenly twists his neck sharply and gazes at you, his\neyes bloodshot and hooded, cereal dribbling from his mouth..... \n\n What do you do? \n 1. Flee in horror from the spectacle before you \n 2. Attack!");
                    string playerChoice = Console.ReadLine();
                    switch (playerChoice)
                    {
                        case "1":
                            Console.WriteLine("The grisly scene before you is too much for your psyche to bear, your mind in tatters, you flee,\nbumbling and raving from the mansion, with this experience haunting the rest of your days.");
                            break;
                        case "2":
                            Console.WriteLine("The grotesque gaze of the creature instills a sense of iminent danger, your mind miraculously\nunbroken by the horrors you have witnessed, you act rashly in self preservation. You strike the man\nbefore you, and much to your surprise, he crumples without a sound......\n");
                            Console.ReadLine();
                            Console.WriteLine("The days that passed seemed like a blur, just mere moments ago you were standing over the body of\nthe man you dethroned. 'You keep what you kill' is the way of the manor, and your predecessor,\nJosh, was astoundingly frail. You now rule the cult that resides in the mansion and the surrounding\nestates, providing suggestions to fledgling coders that are entirely too complex for them to\nimplement at their current skill level. Thus, the cycle of agony continues.\n");
                            break;
                        default:
                            Console.WriteLine("That isn't an option, have you gone mad?");
                            Room2();
                            break;
                    }
                    break;
             default:
             Console.WriteLine("That isn't an option, have you gone mad?");
                    Room2();
             break;
                    
            }
        }
        public void Room3()
        {
            Console.WriteLine("A huge, bloodstained table sits in the center of this filthy kitchen, and in the south-West corner\n lies a heap of furs arranged in the rough approximation of a mattress. The place reeks of rotten meat from\nnumerous poorly executed taxidermy projects that lie scattered around the room, including partially\nstuffed pigs, birds, bobcats, and even a goblin body with a mass of bloody straw and sticks\nprotruding from its neck instead of a head.\n\n What do you do? \n 1 Take the West door \n 2 Move South");
            string playerInput = Console.ReadLine();
            switch (playerInput)
            {
                case "1":
                    if (_player.HasKey == true)
                    {
                        Console.WriteLine("Do you want to use the key? \n 1. Yes \n 2. Keep exploring");

                        string playerChoice = Console.ReadLine();
                        switch (playerChoice)
                        {
                            case "1":
                                Console.WriteLine("You use the key to open the door.  Press enter to procede.");
                                Console.ReadLine();
                                Room2();
                                break;
                            case "2":
                                Room3();
                                break;
                            default:
                                Console.WriteLine("Try again.");
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The door is locked.");
                        Console.WriteLine("\nPress enter to turn around...");
                        Console.ReadLine();
                        Room3();
                        break;
                    }

                case "2":
                    Room6();
                    break;
                default:
                    Console.WriteLine("Please try again.");
                    Console.ReadLine();
                    Room1();
                    break;
            }
        }
        public void Room4()
        {
            Console.WriteLine("The heady air waifs the scent of mildew and rot in this dingy room. Tiny bone carvings of horrific\nwinged creatures lay scattered about room. A moldy blanket in one corner indicates this room was once\ninhabited. Leathery papers lay scattered amidst the rubble and shards of bone. There are two doors:\nthe door on the North wall is locked while the door to the East is slightly ajar.\n\n  What do you do?\n\n 1 Pick the lock on the Northern door\n 2 Push open the Eastern door\n 3 Return to the Foyer to the South.");
            string playerInput = Console.ReadLine();
            {
                switch (playerInput)
                {
                    case "1":
                        Console.WriteLine("The tumblers are rusted but you manage to set the 5 pins without breaking your pick.\nPress enter to open the door...");
                        Console.ReadLine();
                        Room1();
                        break;
                    case "2":
                        Console.WriteLine("You heave against the door and it noisily sways open.\nPress enter to procede...");
                        Console.ReadLine();
                        Room5();
                        break;
                    case "3":
                        Room7();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please choose one of the options.");
                        Room7();
                        break;
                }
            }
        }
        public void Room5()
        {
            Console.WriteLine("The air in this hall is thick and close, stinking of swamp and sweat, with a thick, glistening layer\nof mud on the floor and swaths of oily fungus clinging to the walls. Even more dangling decorations of\npreserved eyes and animal-part relics hang from the ceiling on lengths of sinew here, and what appears\nto be a nest made of rags, sticks, mud, and castoff bits of clothing lies against the northernmost wall.\n  What do you do?\n 1 Move East\n 2 Move West\n 3 Move South.\n 4 Sniff the nest of rags...");
            string playerInput = Console.ReadLine();

            switch (playerInput)
            {
                case "1":
                    Room6();
                    break;
                case "2":
                    Room4();
                    break;
                case "3":
                    Room8();
                    break;
                case "4":
                    Console.WriteLine("Mmmmmmmm..... your mouth waters but you also feel the urge to vomit?\n");
                    Console.WriteLine("Press enter to move on.");
                    Console.ReadLine();
                    Room5();
                    break;
                default:
                    Console.WriteLine("Please try again.");
                    Room5();
                    break;
            }

        }
        public void Room6()
        {
            Console.WriteLine("The dominant feature of this room is a large bed—really nothing more than a nest made of old mattresses,\nloose straw, and mud. The fleas swarming on the “bed” are obvious from several feet away. A large hole\nin the northern wall opens out into what appears to be a kitchen or perhaps it's a slaughtering room...\n  What do you do?\n 1 Move North\n 2 Move West.");
            string playerInput = Console.ReadLine();

            switch (playerInput)
            {
                case "1":
                    Room3();
                    break;
                case "2":
                    Room5();
                    break;
                default:
                    Console.WriteLine("try again dumdum");
                    Room6();
                    break;
            }

        }
        public void Room7()
        {
            Console.WriteLine("Stepping into the foyer you see the remains of the manner are precarious, with fire damaged timbers \n now overgrown with briars and vines. Moving some of the loose debris around reveals the outline of \n a stone slab covering two separate doors.The first door leads North, you feel it rumbling. The second\n door,leading East, appears brand new despite a broken lock.\n\n  Choose your path:\n\n1 Investigate the rumbling behind the door to the North\n2 Discover what lays behind the broken lock...");
            string playerInput = Console.ReadLine();
            {
                switch (playerInput)
                {
                    case "1":
                        Room4();
                        break;
                    case "2":
                        Room8();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please choose one of the options.");
                        Room7();
                        break;
                }
            }
        }
        public void Room8()
        {
            Console.WriteLine("\nThe door opens to reveal a steep and winding staircase that leads down into a dark antechamber, with\nwalls of hewn stone decorated haphazardly in primitive paintings of vicious birds. Two stone doors,\neach bearing a strange symbol that resembles a seven-pointed star, stand closed on the Eastern and\nNorthern walls. The room is dominated by a looming, man-shaped wooden statue, with legs and talons\nof a giant eagle, two sets of eagle wings, a twisted, gem - studded avian head, and a snake in\nplace of genitals.\n\nYou momentarily pause to study the stutue then procede to the doors.\n\n  Where do you go?\n\n 1 Move North\n 2 Move East\n 3 Move West");
            string playerInput = Console.ReadLine();

            switch (playerInput)
            {
                case "1":
                    Room5();
                    break;
                case "2":
                    Room9();
                    break;
                case "3":
                    Room7();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please choose one of the options.");
                    Room7();
                    break;
            }

        }
        public void Room9()
        {
            Console.WriteLine("This room is a ghastly scene. The entire wall is covered in small alcoves although only half are filled\nwith numerous pairs of preserved eyeballs and humanoid tongues, remarkably preserved. In one corner of the\nroom there is a pedestal with a dusty tome filled with pictures of bird demons. Scattered about the\npedestal are three similar tomes one black, one blue and one covered in blood.\n\nAs you walk towards the pedestal the eyes seem to follow you.\n\n  What do you do?\n\n1 Turn back to the antechamber...\n2 Pick up the black book\n3 Pick up the blue book\n4 Pick up the blood covered book");
            string playerInput = Console.ReadLine();

            switch (playerInput)
            {
                case "1":
                    Room8();
                    break;
                case "2":
                    Console.WriteLine("\n     The Land of Galorian\nSouthwest of Avistan, across the Inner Sea is the largely unexplored wilderness of Garund. Whether\none is scouring its northern deserts for lost relics of the Osiriani pharaohs or trekking through\nthe near-impenetrable jungles of the Mwangi Expanse, Garund provides endless adventures for those\nwilling to risk its many dangers.\n\nA thousand miles to the west from the Arch of Aroden are the remnants of the once great island\ncontinent of Azlant, which saw the rise of the first human civilizations. All that remains of Azlant\ntoday is a series of jutting crags and narrow, twisted channels; most of the continent sunk beneath\nthe sea when the Starstone fell from the sky.\n\nPerplexed you put the book down.\n\nPress enter to continue...");
                    Console.ReadLine();
                    Room9();
                    break;
                case "3":
                    Console.WriteLine("\n   Of Monsters and Men\nThe door opens to reveal a steep and winding staircase that leads down into a dark antechamber, with\n\nAzlanti chariot beetles are huge creatures easily capable of crushing a man in their mandibles. Vast\ncarapaces cover their back and shimmer in a manner that draws the eye and has strange inexplicable\neffects on the mind. Apart from its abnormally large size and the strange alluring shimmer of its\nshell, the Azlanti chariot beetle appears as just like a regular beetle.\n\nAzlanti chariot beetles inhabit only the ruins of ancient Azlant. Some strange force compels them to\nfind the remains of their former masters and protect them from intruders. The Azlanti chariot beetles\nwere once mightier creatures than they are today able to transport dozens of war wizards and breathe\nfire. Now all that is left is their shells ability to befuddle the mind.\n\nCreepy...\n\nPress enter to continue...\n");
                    Console.ReadLine();
                    Room9();
                    break;
                case "4":
                    Console.WriteLine("As you go to lift the blood soaked tome it disintegrates in your hands leaving your fingers covered in blood.\nAmidst the falling pages you see the glint of metal and hear a clink as a silver skeleton key falls from the\ntattered pages.\n\nYou pocket the key.\n\n Press Enter to continue.");
                    _player.HasKey = true;
                    Console.ReadLine();
                    Room9();
                    break;
                default:
                    Console.WriteLine("Try again.");
                    Room9();
                    break;
            }

        }


    }
}
