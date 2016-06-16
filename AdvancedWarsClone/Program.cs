using System;
using System.Windows.Forms;

namespace AdvancedWarsClone {
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {            

            using (var game = new Game1())
                game.Run();

        }
    }
}


/// <summary>
/// TODO
/// 
/// Make some sort of menu 
/// 
/// Make rendering resolution independent
/// 
/// Store some level layouts 
///     -- design level layouts
///     -- create population method that can parse those layouts 
/// ^^^ Some sort of map creator that can save to a file 
///  
/// Fully flesh out the terrain and unit classes 
///     -- Make a method that looks at surrounding tiles and gives the proper tile 
///     
/// 
/// Crate some sort of cursor and select menu
///     -- make sure to display empty unit spots as some sort of empty to prevent null errors 
/// 
/// Create game mechanics
///     -- movement 
///         -- how to make that flower of all possible tiles you can move to
///     -- base and city capture 
///     -- combat
///     -- unit creation at certain tiles
///     -- win/loss conditions 
///     -- factions 
///         -- ie the teams that fight against each other 
///     
/// Create player class
///     -- commanding officer
///     -- power 
///     -- description
///     -- unit type modifiers (allow certain CO's to have stronger and or weaker unit types 
///     -- CO special powers   
///         -- Power bar
///         -- How to add to power bar
///         
/// Dialog
///     -- CO pictures
///     -- saved in a file some where 
///     
/// Difficult fluff (probably not going to happen) 
///     -- AI
///     -- some sort of map generator 
/// </summary>