using System;

namespace PI_19SerializacionComposicion
{
    [Serializable]
    public class CMotor
    {
        private int cilindros;
        private int hp;
        public int Cilindros { get => cilindros; set => cilindros = value; }
        public int HP { get => hp; set => hp = value; }
        
        public CMotor()
        {
            cilindros = 4;
            hp = 200;
        }

        public void MuestraMotor()
        {
            Console.WriteLine("====Cilindros:{0}, Caballos de fuerza:{1}",cilindros,hp);
        }
    }

    [Serializable]
    public class CMotorXML
    {
        private int cilindros;
        private int hp;
        public int Cilindros { get => cilindros; set => cilindros = value; }
        public int HP { get => hp; set => hp = value; }

        public CMotorXML()
        {
            cilindros = 4;
            hp = 200;
        }

        public CMotorXML(int pCilindros, int pHP)
        {
            cilindros = pCilindros;
            hp = pHP;
        }
        public void MuestraMotor()
        {
            Console.WriteLine("====Cilindros:{0}, Caballos de fuerza:{1}", cilindros, hp);
        }
    }
}
