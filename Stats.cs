using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gam
{
    class Player
    {
        string m_pName;
        int xp;
        int lvl;
        int atk;
        int mgc;
        int def;
        int shlds;
        int HP;
        string m_Class;
        
        public Player(string pName)
        {
            m_pName = pName;
        }
       public int getXP()
        {
            return xp;
        }
        public int getLVL()
        {
            return lvl;

        }
        public int getAtk()
        {
            return atk;
        }
        public int getMGC()
        {
            return mgc;
        }
        public int getDef()
        {
            return def;
        }
        public int getShlds()
        {
            return shlds;
        }
        public int getHP()
        {
            return atk;
        }
        public string getName()
        {
            return m_pName;
        }
        string ret = "";
       public string getCharacterInfo()
        {
            ret += "--------------------------------------------------";
            ret += "\nName: "+ m_pName + " the " + m_Class;
            ret += "\nHP:      " +      HP  ;
            ret += "\nHP:      " + HP  ;
            ret += "\nDef:     " + def;
            ret += "\nshields: " + shlds;
            ret += "\nAttack:  " + atk;
            ret += "\nMagic    " + mgc;
            return ret;
        }

    }
}
