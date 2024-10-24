namespace ExemploDelegate.Entities
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza soma de dois valores inteiros
        /// </summary>
        /// <param name="a">Primeiro numero</param>
        /// <param name="b">Segundo numero</param>
        /// <returns></returns>
        public static int Somar(int a, int b) => a + b;

        /// <summary>
        /// Realiza subtracao de dois valores inteiros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Subtrair(int a, int b) => a - b;

        /// <summary>
        /// Realiza divisao de dois valores inteiros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Dividir(int a, int b) => a / b;

        /// <summary>
        /// Realiza multiplicacao de dois valores inteiros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Multiplicar(int a, int b) => a * b;
    }
}