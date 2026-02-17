class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int a){
        return ExpectedMinutesInOven() - a;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int a){
        return a*2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int a, int b){
        return PreparationTimeInMinutes(a)+b;
    }
}
