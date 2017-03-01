using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

/*
3. Cel gry: Posiadanie na wszystkich kostkach tej samej wartości(nie ważne jakiej-nie ma starszeństwa między numerami)-w tym momencie gracz wygrywa i gra się kończy. Jeżeli nie wszystkie kostki będą miały ten sam numer-gracz przegrywa.
5. Szczegółowe zasady gry: Na początku gracz wybiera liczbę kostek (co za tym idzie liczbę ścian).
schemat gry jest następujący:
(pula kostek rzucanych)=>(pula szans na rzuty)=>(pula wyniku)
Po pierwszym rzucie gracz wybiera jakiś numer. (dowolny od 1 do n niezależnie co jest na kostkach-oczywiście gdy wybierze numer którego nie wyrzucił to przegrywa).
Kostki z tym numerem są przenoszone z puli kostek rzucanych do puli szans na rzuty. Gracz może rzucać tyle razy ile ma szans na rzuty. Po każdym takim rzucie jedna szansa przechodzi z puli szans do puli wyniku, natomiast kostki z oczekiwanym numerem, przechodzą z puli kostek rzucanych do puli szans.
Gra toczy się albo do momentu gdy wszystkie kostki będą w puli szans lub w puli wyniku (gracz wygrywa),
albo do momentu gdy pula szans będzie pusta (gracz przegrywa).
6. Dodatkowe uwagi. Chciałbym tak jak wspominałem aby przez cały czas gry można było oglądać dynamicznie zmieniające się prawdopodobieństwa (chciałbym żeby wyświetlać dwa prawdopobieństwa-prawdopodobieństwo zwycięstwa i prawdopodobieństwo zwycięstwa w następnym rzucie-to drugie jest prościutkie do policzenia, nad pierwszym pracuje wzorki postaram się niedługo zrobić). Poza tym fajnie by było żeby gracz zatwierdzał każdy następny rzut, aby można było pomiędzy rzutami analizować sytuację i porównywać prawdopodobieństwa-jako walor dydaktyczny gry.
 */

namespace Encube
{
    class Game
    {
        public Game(int n)
        {
            this.N = n;

            this.DicesForRolling = new BindingList<Dice>();
            this.DicesWithChanceForRolling = new BindingList<Dice>();
            this.DicesResult = new BindingList<Dice>();

            this.DicesForRolling = new BindingList<Dice>();
            var random = new Random();

            for (int i = 0; i < n; i++)
                this.DicesForRolling.Add(new Dice(n, random));
        }

        public bool isGameOver()
        {
            if (DicesWithChanceForRolling.Count == 0) //gracz przegrywa
                return true;
            if (DicesForRolling.Count == 0 || DicesWithChanceForRolling.Count == N || DicesResult.Count == N)//gracz wygrywa
                return true;

            return false;
        }

        public int isGameWon()
        {
            if (isGameOver())
            {
                if (DicesForRolling.Count == 0 || DicesWithChanceForRolling.Count == N || DicesResult.Count == N)//gracz wygrywa
                    return 1;

                if (DicesWithChanceForRolling.Count == 0) //gracz przegrywa
                    return 0;
            }
            return -1;//nierozstrzygnięta gra
        }

        public void sortDices()
        {
            var listOfDices = DicesForRolling.ToList();
            listOfDices.Sort((d1, d2) => d1.number.CompareTo(d2.number));
            DicesForRolling = new BindingList<Dice>(listOfDices);
        }

        public void setNumer(int num)
        {
            this.choosenNumber = num;
        }

        public bool isThereNumber(int num)
        {
            bool isthere = false;
            foreach (var dice in DicesForRolling)
                if (dice.number == num)
                    isthere = true;
            return isthere;
        }

        public void moveFromRollingToChances()
        {
            /* Kostki z tym numerem są przenoszone z puli kostek rzucanych do puli szans na rzuty*/
            var dices = DicesForRolling.ToList().FindAll((d) => { return (d.number == choosenNumber); });

            var dicesList1 = DicesWithChanceForRolling.ToList();
            dicesList1.AddRange((dices));
            DicesWithChanceForRolling = new BindingList<Dice>(dicesList1);

            var dicesList2 = DicesForRolling.ToList();
            dicesList2.RemoveAll((d) => { return (d.number == choosenNumber); });

            DicesForRolling = new BindingList<Dice>(dicesList2);
        }

        public void moveFromChancesToResult()
        {
            var dice = DicesWithChanceForRolling[0];
            DicesWithChanceForRolling.RemoveAt(0);
            DicesResult.Add(dice);
        }

        public static string rules()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("1. Cel gry: Posiadanie na wszystkich kostkach tej samej wartości(nie ważne jakiej-nie ma starszeństwa między numerami)-w tym momencie gracz wygrywa i gra się kończy. Jeżeli nie wszystkie kostki będą miały ten sam numer-gracz przegrywa.\n");
            str.AppendLine("2. Szczegółowe zasady gry: Na początku gracz wybiera liczbę kostek (co za tym idzie liczbę ścian).");
            str.AppendLine("\nSchemat gry jest następujący:(pula kostek rzucanych)=>(pula szans na rzuty)=>(pula wyniku)");
            str.AppendLine("\nPo pierwszym rzucie gracz wybiera jakiś numer. (dowolny od 1 do n niezależnie co jest na kostkach-oczywiście gdy wybierze numer którego nie wyrzucił to przegrywa).");
            str.AppendLine("Kostki z tym numerem są przenoszone z puli kostek rzucanych do puli szans na rzuty. Gracz może rzucać tyle razy ile ma szans na rzuty. Po każdym takim rzucie jedna szansa przechodzi z puli szans do puli wyniku, natomiast kostki z oczekiwanym numerem, przechodzą z puli kostek rzucanych do puli szans.");
            str.AppendLine("\n5. Gra toczy się albo do momentu gdy wszystkie kostki będą w puli szans lub w puli wyniku (gracz wygrywa), albo do momentu gdy pula szans będzie pusta (gracz przegrywa).");

            return str.ToString();
        }

        public static string aboutGame()
        {
            return "Gra powstała po kursie Fizyki Statystycznej na specjalności Fizyka Stosowana, na kierunku Fizyka Techniczna, na wydziale Fizyki Technicznej i Matematyki Stosowanej, na uczelni - Politechnika Gdańska. \n\nPod wpływem inspiracji zagadnieniami statystyki i prawdopodobieństwa oraz po zachęceniu do stworzenia gry wykorzystującej prawdopodobieństwo przez dr Mateusza Zawadzkiego z katedry Fizyki Atomowej, Molekularnej i Optycznej Polutechniki Gdańskiej jeden ze studentów - Kordian Czyżewski stworzył grę początkowo nazywaną Encube, jego kolega lubiący propgramować podchwycił pomysł i zaprogramował tę grę w technologii .NET, w języku C# z użyciem Winforms.";
        }

        public static string authors()
        {
            return "Zasady wymyślił: Kordian Czyżewski (kordiancz25@wp.pl)\nKod napisał: Paweł Troka (ptroka@fizyka.dk)\nZainspirował do stworzenia: dr Mateusz Zawadzki (mzawadzki@mif.pg.gda.pl)";
        }

        public BindingList<Dice> DicesForRolling { get; set; }//pula kostek rzucanych
        public BindingList<Dice> DicesWithChanceForRolling { get; set; }//pula szans na rzuty
        public BindingList<Dice> DicesResult { get; set; }//pula wyniku

        private int choosenNumber;
        private int N;
    }
}
