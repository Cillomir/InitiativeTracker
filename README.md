# InitiativeTracker
A lightweight initiative tracker for tabletop gaming
Finished adding options for health, armor class, and ability score tracking. Some features (such as turn tracking and round tracking) are still being worked on.

The tracker is designed to be straightforward, sorting initiative order by using the higher dexterity as a tiebreaker. PC's (Player characters) always go first if both initiative and dexterity is tied, then NPC's (non-player characters, such as allies and hirelings), then MOB's (typically enemy characters).

Party information and encounter groups can be saved to a file, allowing them to be added separately when needed. 
  For example: 
    Prior to game time, set up the party information and save the party to a file (e.g. myParty.txt). 
      Clear the tracker and do the same for an encounter group (e.g. threeThugs.txt).
    When it comes to game time, "Load" the party into the tracker.
      "Add" the encounter group. You can do this once, or add a group multiple times, or add multiple encounter groups.
      Type in the initiative from the rolls and "Sort by Initiative"
