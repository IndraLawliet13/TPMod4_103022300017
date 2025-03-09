namespace TPMod4_103022300017
{
    class KodePos
    {
        public static string getKodePos(string kelurahan)
        {
            switch (kelurahan.ToLower())
            {
                case "batununggal":
                    return "40266";
                case "kujangsari":
                    return "40287";
                case "mengger":
                    return "40267";
                case "wates":
                    return "40256";
                case "cijaura":
                    return "40287";
                case "jatisari":
                    return "40286";
                case "margasari":
                    return "40286";
                case "sekejati":
                    return "40286";
                case "kebonwaru":
                    return "40272";
                case "maleer":
                    return "40274";
                case "samoja":
                    return "40273";
                default:
                    return "Kode Pos Tidak Ditemukan"; // Handle kasus jika kelurahan tidak ditemukan
            }
        }
    }
}
