using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingApostrophes
{
    class Solution
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contractions = new Dictionary<string, string>
            {
                {" arent ", " aren't "},
                {"Arent", "Aren't"},
                {" arent.", " aren't."},
                {" arent,", " aren't,"},
                {"Cant ", "Can't "},
                {" cant ", " can't "},
                {" cant,", " can't,"},
                {" cant.", " can't."},
                {"couldnt", "couldn't"},
                {"didnt", "didn't"},
                {"doesnt", "doesn't"},
                {"dont", "don't"},
                {"hadnt", "hadn't"},
                {"hasnt", "hasn't"},
                {"havent", "haven't"},
                {" hes ", " he's "},
                {" hes.", " he's."},
                {" hes,", " he's,"},
                {"Hes ", "He's "},
                {"Id ", "I'd "},
                {"Ill ", "I'll "},
                {"Im ", "I'm "},
                {"Ive ", "I've "},
                {"isnt", "isn't"},
                {"lets ", "let's "},
                {"mightnt", "mightn't"},
                {"mustnt", "mustn't"},
                {"shant", "shan't"},
                {" shes ", " she's "},
                {" shes.", " she's."},
                {" shes,", " she's,"},
                {"shouldnt", "shouldn't"},
                {"thats", "that's"},
                {"theres", "there's"},
                {"theyd", "they'd"},
                {"theyll", "they'll"},
                {"theyre", "they're"},
                {"theyve", "they've"},
                {" wed ", " we'd "},
                {" weve ", " we've "},
                {"werent", "weren't"},
                {"whatll", "what'll"},
                {"whatre", "what're"},
                {"whats", "what's"},
                {"whatve", "what've"},
                {"wheres", "where's"},
                {"whod", "who'd"},
                {"wholl", "who'll"},
                {"whos", "who's"},
                {"whove", "who've"},
                {"wont", "won't"},
                {"wouldnt", "wouldn't"},
                {"youd", "you'd"},
                {"youll", "you'll"},
                {"youre", "you're"},
                {"youve", "you've"},
                {"partys", "party's"},
                {"oppositions", "opposition's"},
                {"Washingtons", "Washington's"},
                {"Were", "We're"},
                {"ys ", "y's "},
                {"ys.", "y's."},
                {"ys,", "y's,"},
                {"sss", "ss's"},
                {"womans", "woman's"},
                {"Mans", "Man's"},
                {" mans", " man's"},
                {"aint","ain’t"},
                {"amnt","amn’t"},
                {"couldve","could’ve"},
                {"couldntve","couldn’t’ve"},
                {"hadntve","hadn’t’ve"},
                {"hedve","he’d’ve"},
                {"hesnt","he’sn’t"},
                {"howd","how’d"},
                {"howll","how’ll"},
                {" hows "," how’s "},
                {"Idve","I’d’ve"},
                {"Ivent","I’ven’t"},
                {"itd","it’d"},
                {"itdve","it’d’ve"},
                {"itll","it’ll"},
                {"itsnt","it’sn’t"},
                {"maam","ma’am"},
                {"mightntve","mightn’t’ve"},
                {"mightve","might’ve"},
                {"mustve","must’ve"},
                {"neednt","needn’t"},
                {"notve","not’ve"},
                {"oclock","o’clock"},
                {" ol "," ol’ "},
                {"oughtnt","oughtn’t"},
                {"shedve","she’d’ve"},
                {"shesnt","she’sn’t"},
                {"shouldve","should’ve"},
                {"shouldntve","shouldn’t’ve"},
                {"somebodyd","somebody’d"},
                {"somebodydve","somebody’d’ve"},
                {"somebodydntve","somebody’dn’t’ve"},
                {"somebodyll","somebody’ll"},
                {"somebodys","somebody’s"},
                {"someoned","someone’d"},
                {"someonedve","someone’d’ve"},
                {"someonell","someone’ll"},
                {"someones","someone’s"},
                {"somethingd","something’d"},
                {"somethingdve","something’d’ve"},
                {"somethingll","something’ll"},
                {"somethings","something’s"},
                {"thatll","that’ll"},
                {"thered","there’d"},
                {"theredve","there’d’ve"},
                {"therere","there’re"},
                {"theydnt","they’dn’t"},
                {"theydntve","they’dn’t’ve"},
                {"theydve","they’d’ve"},
                {"theydvent","they’d’ven’t"},
                {"theyllntve","they’lln’t’ve"},
                {"theyllvent","they’ll’ven’t"},
                {"theyvent","they’ven’t"},
                {" tis "," ’tis "},
                {" twas "," ’twas "},
                {"wasnt","wasn’t"},
                {"wedve","we’d’ve"},
                {"wedntve","we’dn’t’ve"},
                {"wellntve","we’lln’t’ve"},
                {"whens","when’s"},
                {"whered","where’d"},
                {"whereve","where’ve"},
                {"whodve","who’d’ve"},
                {"whore","who’re"},
                {"whyll","why’ll"},
                {"whyre","why’re"},
                {"whys","why’s"},
                {"wontve","won’t’ve"},
                {"wouldve","would’ve"},
                {"wouldntve","wouldn’t’ve"},
                {"yall","y’all"},
                {"yalldve","y’all’d’ve"},
                {"yalldntve","y’all’dn’t’ve"},
                {"yallll","y’all’ll"},
                {"yallllnt","y’all’lln’t"},
                {"yallllve","y’all’ll’ve"},
                {"yallllvent","y’all’ll’ven’t"},
                {"youdve","you’d’ve"},
                {"yourent","you’ren’t"},
                {"youvent","you’ven’t"},
                {" hed", " he'd"},
                {"Hed", "He'd"}
            };

            string input = string.Empty;
            string nextLine = Console.ReadLine();
            while (!string.IsNullOrEmpty(nextLine))
            {
                input += nextLine + "\n";
                nextLine = Console.ReadLine();
            }

            foreach (string contraction in contractions.Keys)
            {
                if (input.Contains(contraction))
                {
                    input = input.Replace(contraction, contractions[contraction]);
                }
            }

            Console.WriteLine(input);
        }
    }
}
