using System;

namespace liczby_szesnastkowe
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Sumalacja MicroProcer 8086
            
            bool start = true;

            do
            {


                /*****************************************************************************************************/
                //Typy zmiennej//


                string al;
                string ah;
                string bl;
                string bh;
                string cl;
                string ch;
                string dl;
                string dh;

                string rj = "";
                string rj1 = "";
                string rj2 = "";


                Console.WriteLine("Sumalacja MicroProcer 8086\n\n");

                Console.WriteLine("Wartość rejestru może być: 0-9 lub a-f.\n(Np. 00, 93, aa, af, a6, 1c ... .)\n\n ");


                /*****************************************************************************************************/
                                                    //Input//

                //AL//

                do
                {
                    Console.WriteLine("Podaj wartość rejestru AL: ");
                    al = Console.ReadLine();

                } while (sprwdz(al) == false);


                /*****************************************************************************************************/
                //AH//

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj wartość rejestru AH: ");
                    ah = Console.ReadLine();

                } while (sprwdz(ah) == false);

                /*****************************************************************************************************/
                //BL//

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj wartość rejestru BL: ");
                    bl = Console.ReadLine();

                } while (sprwdz(bl) == false);


                /*****************************************************************************************************/
                //BH//

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj wartość rejestru BH:");
                    bh = Console.ReadLine();

                } while (sprwdz(bh) == false);
                /*****************************************************************************************************/
                //CL//

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj wartość rejestru CL:");
                    cl = Console.ReadLine();

                } while (sprwdz(cl) == false);
                /*****************************************************************************************************/
                //CH//

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj wartość rejestru CH:");
                    ch = Console.ReadLine();

                } while (sprwdz(ch) == false);
                /*****************************************************************************************************/
                //DL//

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj wartość rejestru DL:");
                    dl = Console.ReadLine();

                } while (sprwdz(dl) == false);
                /*****************************************************************************************************/
                //DH//

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj wartość rejestru DH:");
                    dh = Console.ReadLine();
                } while (sprwdz(dh) == false);

                /*****************************************************************************************************/
                //Wynik//
                Console.WriteLine("\n\n *********************************** ");
                Console.WriteLine("               Wynik: \n");
                Console.WriteLine("               al:" + al.ToUpper());
                Console.WriteLine("               ah:" + ah.ToUpper());
                Console.WriteLine("               bl:" + bl.ToUpper());
                Console.WriteLine("               bh:" + bh.ToUpper());
                Console.WriteLine("               cl:" + cl.ToUpper());
                Console.WriteLine("               ch:" + ch.ToUpper());
                Console.WriteLine("               dl:" + dl.ToUpper());
                Console.WriteLine("               dh:" + dh.ToUpper());

                Console.WriteLine(" *********************************** ");
                /*****************************************************************************************************/

                //Rozkaz symulacji//




                do
                {
                    Console.WriteLine("\n\nPodaj rozkaz symulacji MOV lub XCHG. Wpisz w konsole 1 lub 2 zeby wybrac MOV lub XCHG.");
                    Console.WriteLine("1 - MOV\n2 - XCHG");

                    rj = Console.ReadLine();

                } while (sprwdz1(rj) == false);


                do
                {
                    Console.WriteLine("\nPodaj pierwszy rejestr"); // do while 
                    rj1 = Console.ReadLine();

                } while (sprwdz_2_1(rj1) == false);

                do
                {
                    Console.WriteLine("\nPodaj drugi rejestr"); // do while  
                    rj2 = Console.ReadLine();

                } while (sprwdz_2_2(rj2) == false);


                /////////////////////////////////////////////////////

                Console.WriteLine();    //Działania "Binarne"
                if (rj == "1")
                {
                    Console.WriteLine("\n\t\tMOV: " + rj1 + " " + rj2);

                    //////////////////////////// AL - ... ///////////////////////////////

                    if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "AH"))
                    {
                        rozkaz_MOV(ref al, ref ah);

                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "BL"))
                    {
                        rozkaz_MOV(ref al, ref bl);

                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "BH"))
                    {
                        rozkaz_MOV(ref al, ref bh);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "CL"))
                    {
                        rozkaz_MOV(ref al, ref cl);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "CH"))
                    {
                        rozkaz_MOV(ref al, ref ch);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "DL"))
                    {
                        rozkaz_MOV(ref al, ref dl);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "DH"))
                    {
                        rozkaz_MOV(ref al, ref dh);
                    }

                    //////////////////////// AH - ... //////////////////////////////////

                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "AL"))
                    {
                        rozkaz_MOV(ref ah, ref al);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "BL"))
                    {
                        rozkaz_MOV(ref ah, ref bl);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "BH"))
                    {
                        rozkaz_MOV(ref ah, ref bh);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "CL"))
                    {
                        rozkaz_MOV(ref ah, ref cl);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "CH"))
                    {
                        rozkaz_MOV(ref ah, ref ch);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "DL"))
                    {
                        rozkaz_MOV(ref ah, ref dl);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "DH"))
                    {
                        rozkaz_MOV(ref ah, ref dh);
                    }

                    //////////////////////// BL - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "AL"))
                    {
                        rozkaz_MOV(ref bl, ref al);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "AH"))
                    {
                        rozkaz_MOV(ref bl, ref ah);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "BH"))
                    {
                        rozkaz_MOV(ref bl, ref bh);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "CL"))
                    {
                        rozkaz_MOV(ref bl, ref cl);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "CH"))
                    {
                        rozkaz_MOV(ref bl, ref ch);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "DL"))
                    {
                        rozkaz_MOV(ref bl, ref dl);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "DH"))
                    {
                        rozkaz_MOV(ref bl, ref dh);
                    }

                    //////////////////////// BH - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "AL"))
                    {
                        rozkaz_MOV(ref bh, ref al);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "AH"))
                    {
                        rozkaz_MOV(ref bh, ref ah);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "BL"))
                    {
                        rozkaz_MOV(ref bh, ref bl);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "CL"))
                    {
                        rozkaz_MOV(ref bh, ref cl);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "CH"))
                    {
                        rozkaz_MOV(ref bh, ref ch);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "DL"))
                    {
                        rozkaz_MOV(ref bh, ref dl);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "DH"))
                    {
                        rozkaz_MOV(ref bh, ref dh);
                    }

                    //////////////////////// CL - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "AL"))
                    {
                        rozkaz_MOV(ref cl, ref al);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "AH"))
                    {
                        rozkaz_MOV(ref cl, ref ah);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "BL"))
                    {
                        rozkaz_MOV(ref cl, ref bl);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "BH"))
                    {
                        rozkaz_MOV(ref cl, ref bh);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "CH"))
                    {
                        rozkaz_MOV(ref cl, ref ch);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "DL"))
                    {
                        rozkaz_MOV(ref cl, ref dl);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "DH"))
                    {
                        rozkaz_MOV(ref cl, ref dh);
                    }

                    //////////////////////// CH - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "AL"))
                    {
                        rozkaz_MOV(ref ch, ref al);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "AH"))
                    {
                        rozkaz_MOV(ref ch, ref ah);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "BL"))
                    {
                        rozkaz_MOV(ref ch, ref bl);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "BH"))
                    {
                        rozkaz_MOV(ref ch, ref bh);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "CL"))
                    {
                        rozkaz_MOV(ref ch, ref cl);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "DL"))
                    {
                        rozkaz_MOV(ref ch, ref dl);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "DH"))
                    {
                        rozkaz_MOV(ref ch, ref dh);
                    }

                    //////////////////////// DL - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "AL"))
                    {
                        rozkaz_MOV(ref dl, ref al);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "AH"))
                    {
                        rozkaz_MOV(ref dl, ref ah);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "BL"))
                    {
                        rozkaz_MOV(ref dl, ref bl);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "BH"))
                    {
                        rozkaz_MOV(ref dl, ref bh);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "CL"))
                    {
                        rozkaz_MOV(ref dl, ref cl);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "CH"))
                    {
                        rozkaz_MOV(ref dl, ref ch);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "DH"))
                    {
                        rozkaz_MOV(ref dl, ref dh);
                    }

                    //////////////////////// DH - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "AL"))
                    {
                        rozkaz_MOV(ref dh, ref al);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "AH"))
                    {
                        rozkaz_MOV(ref dh, ref ah);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "BL"))
                    {
                        rozkaz_MOV(ref dh, ref bl);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "BH"))
                    {
                        rozkaz_MOV(ref dh, ref bh);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "CL"))
                    {
                        rozkaz_MOV(ref dh, ref cl);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "CH"))
                    {
                        rozkaz_MOV(ref dh, ref ch);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "DL"))
                    {
                        rozkaz_MOV(ref dh, ref dl);
                    }

                    /*****************************************************************************************************/
                    //Wynik//
                    Console.WriteLine("\n\n *********************************** ");
                    Console.WriteLine("               Wynik: \n");
                    Console.WriteLine("               al:" + al.ToUpper());
                    Console.WriteLine("               ah:" + ah.ToUpper());
                    Console.WriteLine("               bl:" + bl.ToUpper());
                    Console.WriteLine("               bh:" + bh.ToUpper());
                    Console.WriteLine("               cl:" + cl.ToUpper());
                    Console.WriteLine("               ch:" + ch.ToUpper());
                    Console.WriteLine("               dl:" + dl.ToUpper());
                    Console.WriteLine("               dh:" + dh.ToUpper());

                    Console.WriteLine(" *********************************** ");
                    /*****************************************************************************************************/

                }
                else if (rj == "2")  //Działania "XCHG"
                {
                    Console.WriteLine("\n\t\tXCHG: " + rj1 + " " + rj2);

                    //////////////////////////// AL - ... ///////////////////////////////

                    if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "AH"))
                    {
                        rozakaz_XCHG(ref al, ref ah);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "BL"))
                    {
                        rozakaz_XCHG(ref al, ref bl);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "BH"))
                    {
                        rozakaz_XCHG(ref al, ref bh);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "CL"))
                    {
                        rozakaz_XCHG(ref al, ref cl);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "CH"))
                    {
                        rozakaz_XCHG(ref al, ref ch);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "DL"))
                    {
                        rozakaz_XCHG(ref al, ref dl);
                    }
                    else if ((rj1.ToUpper() == "AL") && (rj2.ToUpper() == "DH"))
                    {
                        rozakaz_XCHG(ref al, ref dh);
                    }

                    //////////////////////// AH - ... //////////////////////////////////

                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "AL"))
                    {
                        rozakaz_XCHG(ref ah, ref al);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "BL"))
                    {
                        rozakaz_XCHG(ref ah, ref bl);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "BH"))
                    {
                        rozakaz_XCHG(ref ah, ref bh);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "CL"))
                    {
                        rozakaz_XCHG(ref ah, ref cl);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "CH"))
                    {
                        rozakaz_XCHG(ref ah, ref ch);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "DL"))
                    {
                        rozakaz_XCHG(ref ah, ref dl);
                    }
                    else if ((rj1.ToUpper() == "AH") && (rj2.ToUpper() == "DH"))
                    {
                        rozakaz_XCHG(ref ah, ref dh);
                    }

                    //////////////////////// BL - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "AL"))
                    {
                        rozakaz_XCHG(ref bl, ref al);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "AH"))
                    {
                        rozakaz_XCHG(ref bl, ref ah);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "BH"))
                    {
                        rozakaz_XCHG(ref bl, ref bh);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "CL"))
                    {
                        rozakaz_XCHG(ref bl, ref cl);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "CH"))
                    {
                        rozakaz_XCHG(ref bl, ref ch);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "DL"))
                    {
                        rozakaz_XCHG(ref bl, ref dl);
                    }
                    else if ((rj1.ToUpper() == "BL") && (rj2.ToUpper() == "DH"))
                    {
                        rozakaz_XCHG(ref bl, ref dh);
                    }

                    //////////////////////// BH - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "AL"))
                    {
                        rozakaz_XCHG(ref bh, ref al);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "AH"))
                    {
                        rozakaz_XCHG(ref bh, ref ah);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "BL"))
                    {
                        rozakaz_XCHG(ref bh, ref bl);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "CL"))
                    {
                        rozakaz_XCHG(ref bh, ref cl);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "CH"))
                    {
                        rozakaz_XCHG(ref bh, ref ch);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "DL"))
                    {
                        rozakaz_XCHG(ref bh, ref dl);
                    }
                    else if ((rj1.ToUpper() == "BH") && (rj2.ToUpper() == "DH"))
                    {
                        rozakaz_XCHG(ref bh, ref dh);
                    }

                    //////////////////////// CL - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "AL"))
                    {
                        rozakaz_XCHG(ref cl, ref al);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "AH"))
                    {
                        rozakaz_XCHG(ref cl, ref ah);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "BL"))
                    {
                        rozakaz_XCHG(ref cl, ref bl);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "BH"))
                    {
                        rozakaz_XCHG(ref cl, ref bh);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "CH"))
                    {
                        rozakaz_XCHG(ref cl, ref ch);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "DL"))
                    {
                        rozakaz_XCHG(ref cl, ref dl);
                    }
                    else if ((rj1.ToUpper() == "CL") && (rj2.ToUpper() == "DH"))
                    {
                        rozakaz_XCHG(ref cl, ref dh);
                    }

                    //////////////////////// CH - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "AL"))
                    {
                        rozakaz_XCHG(ref ch, ref al);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "AH"))
                    {
                        rozakaz_XCHG(ref ch, ref ah);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "BL"))
                    {
                        rozakaz_XCHG(ref ch, ref bl);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "BH"))
                    {
                        rozakaz_XCHG(ref ch, ref bh);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "CL"))
                    {
                        rozakaz_XCHG(ref ch, ref cl);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "DL"))
                    {
                        rozakaz_XCHG(ref ch, ref dl);
                    }
                    else if ((rj1.ToUpper() == "CH") && (rj2.ToUpper() == "DH"))
                    {
                        rozakaz_XCHG(ref ch, ref dh);
                    }

                    //////////////////////// DL - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "AL"))
                    {
                        rozakaz_XCHG(ref dl, ref al);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "AH"))
                    {
                        rozakaz_XCHG(ref dl, ref ah);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "BL"))
                    {
                        rozakaz_XCHG(ref dl, ref bl);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "BH"))
                    {
                        rozakaz_XCHG(ref dl, ref bh);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "CL"))
                    {
                        rozakaz_XCHG(ref dl, ref cl);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "CH"))
                    {
                        rozakaz_XCHG(ref dl, ref ch);
                    }
                    else if ((rj1.ToUpper() == "DL") && (rj2.ToUpper() == "DH"))
                    {
                        rozakaz_XCHG(ref dl, ref dh);
                    }

                    //////////////////////// DH - ... /////////////////////////////////

                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "AL"))
                    {
                        rozakaz_XCHG(ref dh, ref al);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "AH"))
                    {
                        rozakaz_XCHG(ref dh, ref ah);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "BL"))
                    {
                        rozakaz_XCHG(ref dh, ref bl);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "BH"))
                    {
                        rozakaz_XCHG(ref dh, ref bh);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "CL"))
                    {
                        rozakaz_XCHG(ref dh, ref cl);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "CH"))
                    {
                        rozakaz_XCHG(ref dh, ref ch);
                    }
                    else if ((rj1.ToUpper() == "DH") && (rj2.ToUpper() == "DL"))
                    {
                        rozakaz_XCHG(ref dh, ref dl);
                    }

                    /*****************************************************************************************************/
                    //Wynik//
                    Console.WriteLine("\n\n *********************************** ");
                    Console.WriteLine("               Wynik: \n");
                    Console.WriteLine("               al:" + al.ToUpper());
                    Console.WriteLine("               ah:" + ah.ToUpper());
                    Console.WriteLine("               bl:" + bl.ToUpper());
                    Console.WriteLine("               bh:" + bh.ToUpper());
                    Console.WriteLine("               cl:" + cl.ToUpper());
                    Console.WriteLine("               ch:" + ch.ToUpper());
                    Console.WriteLine("               dl:" + dl.ToUpper());
                    Console.WriteLine("               dh:" + dh.ToUpper());

                    Console.WriteLine(" *********************************** ");
                    /*****************************************************************************************************/

                }
                else
                {
                    Console.WriteLine("Nie ma takiego rozkazu");
                }




                /****************************************************************************************************************************/
                /****************************************************************************************************************************/
                /****************************************************************************************************************************/
                //Metody//

                //szenstsk - 0 >= 9  a,A >= f,F
                //Nieszesnastkowy 


                bool sprwdz(string x) //sprawdza nam wpisywanie w konsole rejestrow
                {
                    
                    if (x.Length == 2 && ((x[0] >= '0' && x[0] <= '9') || (x[0] >= 'a' && x[0] <= 'f') || (x[0] >= 'A' && x[0] <= 'F')) && ((x[1] >= '0' && x[1] <= '9') || (x[1] >= 'a' && x[1] <= 'f') || (x[1] >= 'A' && x[1] <= 'F')))
                    {
                        return true;

                    }
                    else
                    {

                        Console.WriteLine("Nieszesnastkowy! Musisz wpisac w konsole 0-9 lub a-f.\n");
                        return false;

                    }
                }



                bool sprwdz1(string rj) // sprawdza czy wybralismy "binarne" lub "XCHG"(szesnastkowy)
                {

                    if (rj == "1" || rj == "2")
                    {

                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Nie spełnia warunek!. Musisz wpisac w konsole 1 lub 2 zeby wybrać ktore dzałanie chcesz wykonywac.\n");
                        return false;

                    }


                }




                bool sprwdz_2_1(string rj1) //Sprawdza wpisywanie pierwszego rejestru
                {

                    if (rj1.ToUpper() == "AL" || rj1.ToUpper() == "AH" || rj1.ToUpper() == "BL" || rj1.ToUpper() == "BH" || rj1.ToUpper() == "CL" || rj1.ToUpper() == "CH" || rj1.ToUpper() == "DL" || rj1.ToUpper() == "DH")
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Nie spełnia warunek! Musisz wpisac podanyj wyzej rejestr. (naprzykład: AL, AH, BL ...)\n");
                        return false;

                    }


                }

                bool sprwdz_2_2(string rj2) //Sprawdza wpisywanie drugiego rejestru
                {

                    if (rj2.ToUpper() == "AL" || rj2.ToUpper() == "AH" || rj2.ToUpper() == "BL" || rj2.ToUpper() == "BH" || rj2.ToUpper() == "CL" || rj2.ToUpper() == "CH" || rj2.ToUpper() == "DL" || rj2.ToUpper() == "DH")
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Nie spełnia warunek! Musisz wpisac podanyj wyzej rejestr. (naprzykład: AL, AH, BL ...)\n");
                        return false;

                    }


                }


                //////////////////////////////////////////////////////////////////////////////////////////////

                static void rozkaz_MOV(ref string rj1, ref string rj2) //Metoda "Binarna"
                {
                    rj1 = rj2;


                }



                static void rozakaz_XCHG(ref string rj1, ref string rj2) //Metoda "XCHG"(szesnastkowa)
                {
                    string temp;

                    temp = rj1;
                    rj1 = rj2;
                    rj2 = temp;


                }

                Console.WriteLine("\nJeżelei chcesz wyjść napisz \"x\", jeżeli chcesz kontynować klikni \"Enter\" \n");
                start = Console.ReadLine() == "x";

            } while (!start); 


        }
    }
}
