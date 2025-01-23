namespace State
{
    public interface IMachineState
    {
        IMachineState AddCoin();
        IMachineState ReturnCoin();
        IMachineState Spin();
        IMachineState PushBall();
    }
}
