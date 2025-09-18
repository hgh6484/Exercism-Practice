class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int input) => (40 - input);

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int input) => (2 * input);

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int input1, int input2) => (PreparationTimeInMinutes(input1)+input2);
    
}
