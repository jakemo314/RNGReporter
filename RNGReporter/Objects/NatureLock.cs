﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNGReporter.Objects
{
    public class NatureLock
    {
        private uint[] lockInfo;
        private int forwardCounter;
        private int backwardCounter;
        private int count;
        private int count2;
        private int lastIndex;
        private int lastIndex2;
        public List<uint> rand;
        private XdRngR rng;
        private XdRng rng2;

        public NatureLock(int lockNum)
        {
            lockInfo = natureLockList(lockNum);
            rand = new List<uint>();
            count = ((lockInfo.Length - 2) / 3) - 1;
            count2 = count + 1;
            lastIndex = lockInfo.Length - 4;
            lastIndex2 = lastIndex + 3;
            rng = new XdRngR(0);
            rng2 = new XdRng(0);
        }

        private uint[] natureLockList(int natureLockIndex)
        {
            switch (natureLockIndex)
            {
                case 0:
                    return new uint[] { 3, 6, 127, 255, 24, 0, 126, 0, 127, 255, 12 }; //Altaria
                case 1:
                    return new uint[] { 4, 1, 0, 126, 18, 0, 126, 12, 0, 126, 0, 127, 255, 6 }; //Arbok
                case 2:
                    return new uint[] { 0, 0 }; //Articuno 
                case 3:
                    return new uint[] { 0, 0 }; //Baltoy 3
                case 4:
                    return new uint[] { 0, 0 }; //Baltoy 1
                case 5:
                    return new uint[] { 2, 1, 127, 255, 0, 127, 255, 24 }; //Baltoy 2
                case 6:
                    return new uint[] { 3, 6, 0, 255, 12, 0, 126, 18, 0, 255, 0 }; //Banette
                case 7:
                    return new uint[] { 0, 0 }; //Beedrill
                case 8:
                    return new uint[] { 3, 6, 0, 126, 0, 127, 255, 6, 0, 190, 12 }; //Butterfree
                case 9:
                    return new uint[] { 0, 0 }; //Carvanha
                case 10:
                    return new uint[] { 2, 6, 127, 255, 24, 0, 126, 6 }; //Chansey
                case 11:
                    return new uint[] { 3, 1, 127, 255, 24, 127, 255, 0, 0, 190, 6 }; //Delcatty
                case 12:
                    return new uint[] { 1, 1, 0, 126, 18 }; //Dodrio
                case 13:
                    return new uint[] { 5, 1, 127, 255, 0, 0, 126, 12, 0, 126, 12, 127, 255, 18, 127, 255, 0 }; //Dragonite
                case 14:
                    return new uint[] { 4, 1, 127, 255, 12, 0, 126, 6, 127, 255, 18, 127, 255, 0 }; //Dugtrio
                case 15:
                    return new uint[] { 3, 1, 127, 255, 24, 0, 126, 18, 127, 255, 12 }; //Duskull
                case 16:
                    return new uint[] { 3, 1, 0, 126, 18, 0, 126, 6, 63, 255, 24 }; //Electabuzz
                case 17:
                    return new uint[] { 0, 0 }; //Exeggutor
                case 18:
                    return new uint[] { 3, 1, 127, 255, 24, 0, 126, 0, 127, 255, 12 }; //Farfetch'd  
                case 19:
                    return new uint[] { 3, 1, 0, 126, 18, 0, 126, 6, 127, 255, 24 }; //Golduck
                case 20:
                    return new uint[] { 2, 1, 127, 255, 18, 127, 255, 12 }; //Grimer
                case 21:
                    return new uint[] { 2, 6, 0, 126, 6, 127, 255, 24 }; //Growlithe
                case 22:
                    return new uint[] { 2, 1, 127, 255, 6, 0, 126, 12 }; //Gulpin 3
                case 23:
                    return new uint[] { 2, 1, 127, 255, 6, 0, 126, 12 }; //Gulpin 1
                case 24:
                    return new uint[] { 4, 1, 0, 126, 0, 0, 126, 0, 127, 255, 6, 0, 126, 12 }; //Gulpin 2
                case 25:
                    return new uint[] { 3, 1, 0, 126, 18, 0, 126, 6, 127, 255, 24 }; //Hitmonchan
                case 26:
                    return new uint[] { 4, 1, 0, 126, 24, 0, 255, 6, 0, 126, 12, 127, 255, 18 }; //Hitmonlee
                case 27:
                    return new uint[] { 0, 0 }; //Houndour 3
                case 28:
                    return new uint[] { 0, 0 }; //Houndour 1
                case 29:
                    return new uint[] { 0, 0 }; //To do houndour 2
                case 30:
                    return new uint[] { 4, 6, 127, 255, 24, 0, 126, 6, 0, 126, 12, 0, 126, 18 }; //Hypno
                case 31:
                    return new uint[] { 3, 1, 0, 255, 12, 0, 126, 18, 0, 255, 0 }; //Kangaskhan
                case 32:
                    return new uint[] { 4, 6, 127, 255, 24, 500, 500, 500, 500, 500, 500, 0, 126, 6 }; //Lapras
                case 33:
                    return new uint[] { 1, 1, 0, 126, 0 }; //Ledyba
                case 34:
                    return new uint[] { 2, 1, 0, 255, 6, 127, 255, 24 }; //Lickitung
                case 35:
                    return new uint[] { 0, 0 }; //Lugia
                case 36:
                    return new uint[] { 2, 1, 127, 255, 18, 0, 126, 0 }; //Lunatone
                case 37:
                    return new uint[] { 3, 6, 0, 126, 12, 127, 255, 6, 127, 255, 24 }; //Marcargo
                case 38:
                    return new uint[] { 3, 1, 0, 126, 0, 191, 255, 18, 127, 255, 18 }; //Magmar 
                case 39:
                    return new uint[] { 3, 1, 0, 126, 12, 127, 255, 0, 0, 255, 18 }; //Magneton
                case 40:
                    return new uint[] { 2, 1, 0, 126, 18, 127, 255, 6 }; //Makuhita
                case 41:
                    return new uint[] { 2, 1, 0, 126, 0, 127, 255, 24 }; //Makuhita Colo
                case 42:
                    return new uint[] { 1, 1, 0, 126, 6 }; //Manectric
                case 43:
                    return new uint[] { 0, 0 }; //Mareep 3
                case 44:
                    return new uint[] { 2, 1, 0, 126, 12, 127, 255, 24 }; //Mareep 1
                case 45:
                    return new uint[] { 3, 1, 0, 255, 0, 0, 126, 12, 127, 255, 24 }; //Mareep 2
                case 46:
                    return new uint[] { 4, 1, 127, 255, 24, 500, 500, 500, 500, 500, 500, 0, 126, 6 }; //Marowak
                case 47:
                    return new uint[] { 2, 1, 0, 126, 18, 127, 255, 6 }; //Mawile
                case 48:
                    return new uint[] { 3, 1, 0, 126, 18, 0, 126, 0, 63, 255, 6 }; //Meowth
                case 49:
                    return new uint[] { 0, 0 }; //Moltres
                case 50:
                    return new uint[] { 4, 6, 0, 126, 6, 127, 255, 24, 127, 255, 18, 127, 255, 18 }; //Mr. Mime
                case 51:
                    return new uint[] { 2, 1, 0, 126, 0, 127, 255, 24 }; //Natu
                case 52:
                    return new uint[] { 3, 1, 0, 126, 12, 127, 255, 18, 127, 255, 0 }; //Nosepass
                case 53:
                    return new uint[] { 3, 1, 0, 126, 24, 0, 255, 0, 127, 255, 6 }; //Numel
                case 54:
                    return new uint[] { 2, 1, 0, 126, 6, 127, 255, 24 }; //Paras
                case 55:
                    return new uint[] { 2, 1, 32, 255, 18, 127, 255, 12 }; //Pidgeotto
                case 56:
                    return new uint[] { 1, 1, 127, 255, 6 }; //Pineco
                case 57:
                    return new uint[] { 3, 6, 0, 126, 0, 191, 255, 18, 127, 255, 18 }; //Pinsir
                case 58:
                    return new uint[] { 4, 1, 0, 126, 6, 127, 255, 24, 127, 255, 18, 127, 255, 18 }; //Poliwrath
                case 59:
                    return new uint[] { 1, 1, 0, 126, 12 }; //Poochyena
                case 60:
                    return new uint[] { 4, 1, 127, 255, 24, 0, 126, 6, 0, 126, 12, 0, 126, 18 }; //Primeape
                case 61:
                    return new uint[] { 3, 1, 127, 255, 18, 0, 126, 6, 63, 255, 0 }; //Ralts
                case 62:
                    return new uint[] { 3, 1, 0, 126, 12, 127, 255, 6, 127, 255, 24 }; //Rapidash
                case 63:
                    return new uint[] { 3, 1, 127, 255, 18, 500, 500, 500, 0, 126, 18 }; //Raticate
                case 64:
                    return new uint[] { 0, 0 }; //Rhydon
                case 65:
                    return new uint[] { 2, 1, 127, 255, 18, 127, 255, 6 }; //Roselia
                case 66:
                    return new uint[] { 3, 6, 0, 126, 18, 0, 126, 6, 127, 255, 24 }; //Sableye
                case 67:
                    return new uint[] { 1, 6, 0, 126, 6 }; //Salamence
                case 68:
                    return new uint[] { 2, 1, 127, 255, 24, 0, 126, 6 }; //Scyther
                case 69:
                    return new uint[] { 0, 0 }; //To do seedot 3
                case 70:
                    return new uint[] { 5, 1, 127, 255, 12, 127, 255, 0, 0, 126, 12, 0, 126, 24, 127, 255, 6 }; //Seedot 1
                case 71:
                    return new uint[] { 5, 1, 127, 255, 6, 0, 126, 0, 0, 126, 0, 0, 126, 24, 127, 255, 6 }; //Seedot 2
                case 72:
                    return new uint[] { 3, 1, 0, 126, 18, 127, 255, 12, 127, 255, 6 }; //Seel
                case 73:
                    return new uint[] { 0, 0 }; //Shellder
                case 74:
                    return new uint[] { 2, 1, 0, 126, 0, 0, 126, 24 }; //Shroomish
                case 75:
                    return new uint[] { 3, 6, 0, 126, 18, 0, 126, 6, 63, 255, 24 }; //Snorlax
                case 76:
                    return new uint[] { 1, 1, 0, 126, 6 }; //Snorunt
                case 77:
                    return new uint[] { 3, 1, 0, 126, 0, 127, 255, 6, 0, 255, 24 }; //Solrock
                case 78:
                    return new uint[] { 2, 1, 0, 126, 6, 127, 255, 18 }; //Spearow
                case 79:
                    return new uint[] { 3, 1, 0, 255, 0, 0, 126, 12, 127, 255, 24 }; //Spheal 3
                case 80:
                    return new uint[] { 2, 1, 0, 126, 12, 127, 255, 24 }; //Spheal 1
                case 81:
                    return new uint[] { 3, 1, 0, 255, 0, 0, 126, 12, 127, 255, 24 }; //Spheal 2
                case 82:
                    return new uint[] { 2, 1, 127, 255, 6, 0, 126, 12 }; //Spinarak
                case 83:
                    return new uint[] { 5, 1, 127, 255, 18, 500, 500, 500, 0, 126, 0, 127, 255, 6, 0, 255, 24 }; //Starmie
                case 84:
                    return new uint[] { 0, 0 }; //Swellow
                case 85:
                    return new uint[] { 2, 1, 127, 255, 0, 0, 126, 18 }; //Swinub
                case 86:
                    return new uint[] { 3, 1, 0, 126, 0, 127, 255, 6, 0, 190, 12 }; //Tangela
                case 87:
                    return new uint[] { 0, 0 }; //Tauros
                case 88:
                    return new uint[] { 0, 0 }; //Teddiursa
                case 89:
                    return new uint[] { 0, 0 }; //Togepi
                case 90:
                    return new uint[] { 3, 1, 127, 255, 12, 0, 255, 24, 0, 126, 18 }; //Venomoth
                case 91:
                    return new uint[] { 3, 1, 0, 126, 12, 127, 255, 12, 127, 255, 0 }; //Voltorb
                case 92:
                    return new uint[] { 3, 1, 127, 255, 18, 0, 126, 6, 127, 255, 0 }; //Vulpix
                case 93:
                    return new uint[] { 3, 6, 127, 255, 12, 0, 255, 24, 0, 126, 18 }; //Weepinbell
                case 94:
                    return new uint[] { 0, 0 }; //Zangoose
                default:
                    return new uint[] { 0, 0 }; //Zapdos 
            }
        }

        public bool method1FirstShadow(uint seed)
        {
            backwardCounter = 7;
            forwardCounter = 7;
            rng.Seed = seed;
            rng.GetNext32BitNumber();

            //Build temp pid first to not waste time populating if first backwards nl fails
            uint pid = getPIDReverse();

            //Backwards nature lock check
            uint genderval = pid & 255;
            if (genderval < lockInfo[2] || genderval > lockInfo[3] || !((pid - 25 * (pid / 25)) == lockInfo[4]))
                return false;

            for (int x = 1; x <= count; x++)
            {
                backwardCounter += 5;
                for (int i = 0; i < 3; i++)
                    rng.GetNext32BitNumber();
                pid = getPIDReverse();
                genderval = pid & 255;
                if ((genderval >= lockInfo[2 + 3 * x] && genderval <= lockInfo[3 + 3 * x]) || (lockInfo[2 + 3 * x] == 500 && lockInfo[3 + 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[4 + 3 * x]) || (lockInfo[4 + 3 * x] == 500)))
                    {
                        countBackTwo(x);
                    }
                }
                else
                {
                    countBackTwo(x);
                }
            }

            rng2.Seed = rng.Seed;
            rng2.GetNext32BitNumber();

            //Forwards nature lock check
            for (int x = 1; x <= count; x++)
            {
                forwardCounter += 5;
                for (int b = 0; b < 3; b++)
                    rng2.GetNext32BitNumber();
                pid = getPIDForward();
                genderval = pid & 255;
                if ((genderval >= lockInfo[lastIndex + 1 - 3 * x] && genderval <= lockInfo[lastIndex + 2 - 3 * x]) || (lockInfo[lastIndex + 1 - 3 * x] == 500 && lockInfo[lastIndex + 1 - 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[lastIndex + 3 - 3 * x]) || (lockInfo[lastIndex + 3 - 3 * x] == 500)))
                    {
                        {
                            countForwardTwo(x);
                        }
                    }
                }
                else
                {
                    countForwardTwo(x);
                }
            }

            return forwardCounter == backwardCounter;
        }

        public bool method1SecondShadowUnset(uint seed)
        {
            backwardCounter = 14;
            forwardCounter = 14;
            rng.Seed = seed;
            for (int c = 0; c < 8; c++)
                rng.GetNext32BitNumber();

            //Build temp pid first to not waste time populating if first nl fails
            uint pid = getPIDReverse();

            //Backwards nature lock check
            uint genderval = pid & 255;
            if (genderval < lockInfo[2] || genderval > lockInfo[3] || !((pid - 25 * (pid / 25)) == lockInfo[4]))
                return false;

            for (int x = 1; x <= count; x++)
            {
                backwardCounter += 5;
                for (int i = 0; i < 3; i++)
                    rng.GetNext32BitNumber();
                pid = getPIDReverse();
                genderval = pid & 255;
                if ((genderval >= lockInfo[2 + 3 * x] && genderval <= lockInfo[3 + 3 * x]) || (lockInfo[2 + 3 * x] == 500 && lockInfo[3 + 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[4 + 3 * x]) || (lockInfo[4 + 3 * x] == 500)))
                    {
                        countBackTwo(x);
                    }
                }
                else
                {
                    countBackTwo(x);
                }
            }

            rng2.Seed = rng.Seed;
            rng2.GetNext32BitNumber();

            //Forwards nature lock check
            for (int x = 1; x <= count; x++)
            {
                forwardCounter += 5;
                for (int b = 0; b < 3; b++)
                    rng2.GetNext32BitNumber();
                pid = getPIDForward();
                genderval = pid & 255;
                if ((genderval >= lockInfo[lastIndex + 1 - 3 * x] && genderval <= lockInfo[lastIndex + 2 - 3 * x]) || (lockInfo[lastIndex + 1 - 3 * x] == 500 && lockInfo[lastIndex + 1 - 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[lastIndex + 3 - 3 * x]) || (lockInfo[lastIndex + 3 - 3 * x] == 500)))
                    {
                        countForwardTwo(x);
                    }
                }
                else
                {
                    countForwardTwo(x);
                }
            }

            return forwardCounter == backwardCounter;
        }

        public bool method1SecondShadowSet(uint seed)
        {
            backwardCounter = 12;
            forwardCounter = 12;
            rng.Seed = seed;
            for (int c = 0; c < 6; c++)
                rng.GetNext32BitNumber();

            //Build temp pid first to not waste time populating if first nl fails
            uint pid = getPIDReverse();

            //Backwards nature lock check
            uint genderval = pid & 255;
            if (genderval < lockInfo[2] || genderval > lockInfo[3] || !((pid - 25 * (pid / 25)) == lockInfo[4]))
                return false;

            for (int x = 1; x <= count; x++)
            {
                backwardCounter += 5;
                for (int i = 0; i < 3; i++)
                    rng.GetNext32BitNumber();
                pid = getPIDReverse();
                genderval = pid & 255;
                if ((genderval >= lockInfo[2 + 3 * x] && genderval <= lockInfo[3 + 3 * x]) || (lockInfo[2 + 3 * x] == 500 && lockInfo[3 + 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[4 + 3 * x]) || (lockInfo[4 + 3 * x] == 500)))
                    {
                        countBackTwo(x);
                    }
                }
                else
                {
                    countBackTwo(x);
                }
            }

            rng2.Seed = rng.Seed;
            rng2.GetNext32BitNumber();

            //Forwards nature lock check
            for (int x = 1; x <= count; x++)
            {
                forwardCounter += 5;
                for (int b = 0; b < 3; b++)
                    rng2.GetNext32BitNumber();
                pid = getPIDForward();
                genderval = pid & 255;
                if ((genderval >= lockInfo[lastIndex + 1 - 3 * x] && genderval <= lockInfo[lastIndex + 2 - 3 * x]) || (lockInfo[lastIndex + 1 - 3 * x] == 500 && lockInfo[lastIndex + 1 - 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[lastIndex + 3 - 3 * x]) || (lockInfo[lastIndex + 3 - 3 * x] == 500)))
                    {
                        countForwardTwo(x);
                    }
                }
                else
                {
                    countForwardTwo(x);
                }
            }

            return forwardCounter == backwardCounter;
        }

        public bool method1SecondShadowShinySkip(uint seed)
        {
            backwardCounter = 14;
            forwardCounter = 14;
            rng.Seed = seed;
            for (int c = 0; c < 1; c++)
                rng.GetNext32BitNumber();

            uint pid, psv, psvtemp;
            bool shinyFlag = true;

            //Check how many advances from shiny skip and build initial pid for first nl
            pid = getPIDReverse();
            psv = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
            while (shinyFlag)
            {
                backwardCounter += 2;
                pid = getPIDReverse();
                psvtemp = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
                if (psvtemp != psv)
                    shinyFlag = false;
                else
                    psv = psvtemp;
            }

            //Backwards nature lock check
            uint genderval = pid & 255;
            if (genderval < lockInfo[2] || genderval > lockInfo[3] || !((pid - 25 * (pid / 25)) == lockInfo[4]))
                return false;

            for (int x = 1; x <= count; x++)
            {
                backwardCounter += 5;
                for (int i = 0; i < 3; i++)
                    rng.GetNext32BitNumber();
                pid = getPIDReverse();
                genderval = pid & 255;
                if ((genderval >= lockInfo[2 + 3 * x] && genderval <= lockInfo[3 + 3 * x]) || (lockInfo[2 + 3 * x] == 500 && lockInfo[3 + 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[4 + 3 * x]) || (lockInfo[4 + 3 * x] == 500)))
                    {
                        countBackTwo(x);
                    }
                }
                else
                {
                    countBackTwo(x);
                }
            }

            rng2.Seed = rng.Seed;
            rng2.GetNext32BitNumber();

            //Forwards nature lock check
            for (int x = 1; x <= count; x++)
            {
                forwardCounter += 5;
                for (int b = 0; b < 3; b++)
                    rng2.GetNext32BitNumber();
                pid = getPIDForward();
                genderval = pid & 255;
                if ((genderval >= lockInfo[lastIndex + 1 - 3 * x] && genderval <= lockInfo[lastIndex + 2 - 3 * x]) || (lockInfo[lastIndex + 1 - 3 * x] == 500 && lockInfo[lastIndex + 1 - 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[lastIndex + 3 - 3 * x]) || (lockInfo[lastIndex + 3 - 3 * x] == 500)))
                    {
                        countForwardTwo(x);
                    }
                }
                else
                {
                    countForwardTwo(x);
                }
            }

            for (int d = 0; d < 5; d++)
                rng2.GetNext32BitNumber();

            pid = getPIDForward();
            psv = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
            shinyFlag = true;
            while (shinyFlag)
            {
                forwardCounter += 2;
                pid = getPIDForward();
                psvtemp = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
                if (psvtemp != psv)
                    shinyFlag = false;
                else
                    psv = psvtemp;
            }

            return forwardCounter == backwardCounter;
        }

        public void method2FirstShadow(out uint pid, out uint iv1, out uint iv2)
        {
            uint genderval;
            pid = 0;
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                bool flag = true;
                genderval = pid & 255;
                if ((genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x]) || (lockInfo[lastIndex2 - 2 - 3 * x] == 500 && lockInfo[lastIndex2 - 1 - 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x]) || (lockInfo[lastIndex2 - 3 * x] == 500)))
                    {
                        while (flag)
                        {
                            forwardCounter += 2;
                            pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                            genderval = pid & 255;
                            if (genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x])
                                if ((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x])
                                    flag = false;
                        }
                    }
                }
                else
                {
                    while (flag)
                    {
                        forwardCounter += 2;
                        pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                        genderval = pid & 255;
                        if (genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x])
                            if ((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x])
                                flag = false;
                    }
                }
            }

            pid = (rand[forwardCounter + 6] & 0xFFFF0000) | (rand[forwardCounter + 7] >> 16);
            iv1 = rand[forwardCounter + 3];
            iv2 = rand[forwardCounter + 4];
        }

        public void method2SecondShadowSet(out uint pid, out uint iv1, out uint iv2)
        {
            uint genderval;
            pid = 0;
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                bool flag = true;
                genderval = pid & 255;
                if ((genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x]) || (lockInfo[lastIndex2 - 2 - 3 * x] == 500 && lockInfo[lastIndex2 - 1 - 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x]) || (lockInfo[lastIndex2 - 3 * x] == 500)))
                    {
                        while (flag)
                        {
                            forwardCounter += 2;
                            pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                            genderval = pid & 255;
                            if (genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x])
                                if ((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x])
                                    flag = false;
                        }
                    }
                }
                else
                {
                    while (flag)
                    {
                        forwardCounter += 2;
                        pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                        genderval = pid & 255;
                        if (genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x])
                            if ((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x])
                                flag = false;
                    }
                }
            }

            forwardCounter += 5;
            pid = (rand[forwardCounter + 6] & 0xFFFF0000) | (rand[forwardCounter + 7] >> 16);
            iv1 = rand[forwardCounter + 3] >> 16;
            iv2 = rand[forwardCounter + 4] >> 16;
        }

        public void method2SecondShadowUnset(out uint pid, out uint iv1, out uint iv2)
        {
            uint genderval;
            pid = 0;
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                bool flag = true;
                genderval = pid & 255;
                if ((genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x]) || (lockInfo[lastIndex2 - 2 - 3 * x] == 500 && lockInfo[lastIndex2 - 1 - 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x]) || (lockInfo[lastIndex2 - 3 * x] == 500)))
                    {
                        while (flag)
                        {
                            forwardCounter += 2;
                            pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                            genderval = pid & 255;
                            if (genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x])
                                if ((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x])
                                    flag = false;
                        }
                    }
                }
                else
                {
                    while (flag)
                    {
                        forwardCounter += 2;
                        pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                        genderval = pid & 255;
                        if (genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x])
                            if ((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x])
                                flag = false;
                    }
                }
            }

            forwardCounter += 7;
            pid = (rand[forwardCounter + 6] & 0xFFFF0000) | (rand[forwardCounter + 7] >> 16);
            iv1 = rand[forwardCounter + 3] >> 16;
            iv2 = rand[forwardCounter + 4] >> 16;
        }

        public void method2SecondShinySkip(out uint pid, out uint iv1, out uint iv2)
        {
            uint genderval;
            pid = 0;
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                bool flag = true;
                genderval = pid & 255;
                if ((genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x]) || (lockInfo[lastIndex2 - 2 - 3 * x] == 500 && lockInfo[lastIndex2 - 1 - 3 * x] == 500))
                {
                    if (!(((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x]) || (lockInfo[lastIndex2 - 3 * x] == 500)))
                    {
                        while (flag)
                        {
                            forwardCounter += 2;
                            pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                            genderval = pid & 255;
                            if (genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x])
                                if ((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x])
                                    flag = false;
                        }
                    }
                }
                else
                {
                    while (flag)
                    {
                        forwardCounter += 2;
                        pid = (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
                        genderval = pid & 255;
                        if (genderval >= lockInfo[lastIndex2 - 2 - 3 * x] && genderval <= lockInfo[lastIndex2 - 1 - 3 * x])
                            if ((pid - 25 * (pid / 25)) == lockInfo[lastIndex2 - 3 * x])
                                flag = false;
                    }
                }
            }

            pid = (rand[forwardCounter + 6] & 0xFFFF0000) | (rand[forwardCounter + 7] >> 16);
            bool shiny = true;
            uint psv, psvtemp;
            psv = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
            while (shiny)
            {
                forwardCounter += 2;
                pid = (rand[forwardCounter + 6] & 0xFFFF0000) | (rand[forwardCounter + 7] >> 16);
                psvtemp = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
                if (psvtemp != psv)
                    shiny = false;
                else
                    psv = psvtemp;
            }

            forwardCounter += 7;
            pid = (rand[forwardCounter + 6] & 0xFFFF0000) | (rand[forwardCounter + 7] >> 16);
            iv1 = rand[forwardCounter + 3] >> 16;
            iv2 = rand[forwardCounter + 4] >> 16;
        }

        public uint getType()
        {
            return lockInfo[1];
        }

        private uint getPIDReverse()
        {
            return rng.GetNext16BitNumber() | (rng.GetNext32BitNumber() & 0xFFFF0000);
        }

        private uint getPIDForward()
        {
            return (rng2.GetNext32BitNumber() & 0xFFFF0000) | rng2.GetNext16BitNumber();
        }

        private void countBackTwo(int x)
        {
            backwardCounter += 2;
            uint pid = getPIDReverse();
            uint genderval = pid & 255;
            while (genderval < lockInfo[2 + 3 * x] || genderval > lockInfo[3 + 3 * x] || !((pid - 25 * (pid / 25)) == lockInfo[4 + 3 * x]))
            {
                backwardCounter += 2;
                pid = getPIDReverse();
                genderval = pid & 255;
            }
        }

        private void countForwardTwo(int x)
        {
            forwardCounter += 2;
            uint pid = getPIDForward();
            uint genderval = pid & 255;
            while (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || !((pid - 25 * (pid / 25)) == lockInfo[lastIndex + 3 - 3 * x]))
            {
                forwardCounter += 2;
                pid = getPIDForward();
                genderval = pid & 255;
            }
        }
    }
}