using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;
    /// <summary>
    /// Esta clase comprueba si una contraaseña es segura, poco segura, muy segura o nada segura.
    /// <remarks>Cuantos mas tipos de caracteres lleve mas seguro sera</remarks>
    /// </summary>
    public class comprobadorDePassword
    {
        public string pwd;

        private bool mins;
        private bool mays;
        private bool nums;
        private bool length;

        public bool Mins { get => mins; set { value = mins; } }
        private bool Mays { get => mays; set { value = mays; } }
        private bool Nums { get => nums; set { value = nums; } }
        private bool Length { get => length; set { value = length; } }

        public comprobadorDePassword()
        {
            mins = mays = nums = length = false;
        }

        public int Test(string pass)
        {
            pwd = pass;

            if (pwd==null || pwd.Length <= 0)
            {
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error
            }
                

            if (pwd.Length < 6 && pwd.Length > 0)
            {
                return 0; // No tiene la longitud mínima, error
            }


            if (pwd.Length > 12)
            {
                length = true;
            }

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            foreach (char cadena in pwd)
            {
                if (char.IsLower(cadena))
                {
                    mins = true;
                }
            }
            foreach (char cadena in pwd)
            {
                if (char.IsUpper(cadena))
                {
                    mays = true;
                }
            }
            foreach (char cadena in pwd)
            {
                if (char.IsDigit(cadena))
                {
                    nums = true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int fortaleza = 0;
            if (mins) fortaleza++;
            if (mays) fortaleza++;
            if (nums) fortaleza++;
            if (length) fortaleza++;

            return fortaleza;
        }
    }
}
