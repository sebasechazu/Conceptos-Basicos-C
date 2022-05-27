static void ejecutarHilo()
{
    //Hacer que se tarde 30000 milisegundos (30 segundos) 
    Thread.Sleep(30000);
    Console.WriteLine("HILO EJECUTADO");
}
while (true)
{
    ejecutarHilo();
}
