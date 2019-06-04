/**
 * This class is for displaying story text to the screen when a function is called.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StoryTextClass
    {
        public string OpeningScene()
        {
            return " A meteor has collided with our moon. The affect has caused a change in the DNA of not only some humans but many animals as well. These “Affected” have become carnivorous. They seem to have lost all humanity – no sense of loss, empathy, happiness... Not even love! The Affected simply have a desire to consume.\n\n" +
                "Many people have been killed by these Affected. Others, once bitten, have had the unexpected outcoming of having their own DNA affected like a virus thus becoming one of the Affected themselves.\n\n" +
                "In an effort to protect themselves, the Unaffected have created sanctuary locations such as homes, former stores, and former cites to provide 24/7 shelter from these “zombies”. The locations of these Sanctuaries were given out by pamphlets, billboards and radio.\n\n" +
                "That was months ago.  Some Sanctuaries have been overrun by Affected. A few lack supplies. You presently reside in a Sanctuary that is lacking supplies. You have volunteered to seek help from another Sanctuary. Heroic? Maybe? But tell me, what would you did if your family was in trouble?";
        }

        public string OutskirtsDescription()
        {
            return " You have finally arrived to the town that has been renamed “Zombieland”. It houses the largest Sanctuary but also the largest amount of Affected.\n\n"  
            + "Looking around there is an abandoned Welcome Station, the deserted highway you followed, and what was once a beautiful forested area.\n\n"  
            + "Look around for clues.";
        }

        public string QuickStopDescription()
        {
            return " Inside the city, you have located a Quick Stop. These former gas stations may not have any gas. But they are a treasure trove of supplies. Food can be found here. Expiration dates are a suggestion now that supplies are low. Light sources such as flash lights and lighters can be a huge help as well.\n\n"
                + "Don’t forget to be careful. This Quick Stop is small and enclosed. If an Affected is there, it could mean trouble for you.";
        }

        public string WalmartDescription()
        {
            return " Even in these times, there’s a Walmart. Oh the irony. How useful they are now. They have everything. While your Sanctuary could use a folding bed, you have no way to carry that. Look for clothing, food, and medical supplies. Any medicine can be store for later use. Also, look around for anything your Sanctuary can use as weapons. It is most important to stay alert here. Affected have been seen in and around this store."; 
        }

        public string SafeZoneDescription()
        {
            return " Sanctuary! You have made it. They have agreed to help. However, they want your help first. Is this mission going to get you back to your family? Can you really refuse to help?";
        }

        public string MarathonDescription()
        {
            return " Just like the Quick Stop, this place can be a trove of supplies. Larger than the Quick Stop, many Marathons also contain clothing for truckers. While not everyone in your Sanctuary are truckers, the clothes can be repurposed. Again, look around for food and even first aid kits.";
        }


        #region Finding Items
        public string NothingOfValue()
        {
            return " You did not find anything of value. ";
        }

        public string FoundHammer()
        {
            return " You found a Hammer. This can be used to break through the walls of the city.";
        }

        public string FoundFlashlight()
        {
            return " You found a Flashlight. This can be used light your way through walmart to look for supplies.";
        }

        public string FoundKeyToSafeZone()
        {
            return " You found a Key to the Safe Zone. This can be used unlock the door to the Safe Zone.";
        }

        public string FoundHiddenPathToMarathon()
        {
            return " You found the Hidden Path to the Marathon. This can be used to get to the Marathon with little to no zombie activity.";
        }
        #endregion

        #region Leaving and Entering
        public string LeavingRestrictSouthEnd()
        {
            return " You cannot leave the outskirts of the city. You must continue forward if you wish to find safety.";
        }

        public string LeavingRestrictNorthEnd()
        {
            return " You cannot advance any further because there is no where to go past the marathon.";
        }

        public string LeavingRestrictDirection()
        {
            return " You cannot continue forward because you do not have the item that can give you acces to the next area.";
        }
        #endregion
    }
}
