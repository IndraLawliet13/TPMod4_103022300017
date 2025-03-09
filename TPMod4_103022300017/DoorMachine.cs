class DoorMachine
{
    private enum State
    {
        Terkunci,
        Terbuka
    }

    private State currentState = State.Terkunci;
    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            // C. & D. Tampilkan pesan
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
    public void KunciPintu()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
