namespace 다형성
{
    //다형성(Polymorpism) :Ex 반지의 제왕 -> 용이 인간으로 -> 폴리모프
    // 동일한 이름의 클래스가 다양한 형태의 클래스로 변환할 수 있음.
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal eagle = new Eagle();
            Animal tiger = new Tiger();
            Animal Shark = new Shark();

            Worker worker = new Worker();

            worker.CareAnimal(tiger);
            worker.CareAnimal(Shark);
            worker.CareAnimal(eagle);

            worker.Function(eagle);
            worker.Function(tiger);
            worker.Function(Shark);
        }
    }
}