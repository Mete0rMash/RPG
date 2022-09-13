 public enum State
    {
        NullState = 0,
        Spawn,
        Idle,
        Patrol,
        Chase,
        Attack,
        Dead
    };

 public enum Transition
    {
        NullTransition = 0,
        Initialize,
        OnStandEnemyFound,
        NoEnemyFound,
        NoInteraction,
        EnemyFound,
        EnemySpotted,
        OnRange,
        EnemyLostSight,
        OutOfRange,
        HPZero
    };

public enum QuestState
    {
        inactive,
        active,
        finished
    };

public enum ObjectiveStatus
{
    inactive,
    active,
    finished
};

public enum Levels
{
    Menu = 0,
    lvl1,
    lvl2
}

public enum EquipType
{

}