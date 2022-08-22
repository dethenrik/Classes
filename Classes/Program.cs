namespace Classes
{
    class program
    {
        static void Main(string[] args)
        {

            ModulusClass.str = "-";
            ModulusClass.Modulus(3600, 360);//360 er antal gange den skal tælle og 3600 er total tallet den skal tælle op til, det vil sige den tæller til 360 10 gange i forhold til classen der er lavet.

            SQL.Read();
        }

    }
}