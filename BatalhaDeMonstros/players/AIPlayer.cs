using System;

public class AIPlayer : Player
{
    public AIPlayer(string name) : base(name) {}

    public void TakeTurn(Monster opponent)
    {
        Random rand = new Random();
        int action = rand.Next(0, 3);

        IAction actionToExecute;
        switch (action)
        {
            case 0:
                actionToExecute = new Attack();
                break;
            case 1:
                actionToExecute = new Defend();
                break;
            default:
                actionToExecute = new SpecialAbility();
                break;
        }

        actionToExecute.Execute(Monster, opponent);
    }
}
