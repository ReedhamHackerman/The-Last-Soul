using UnityEngine;

//this class runs "numOfIterations" iterations of the Monty Hall game, where the virtual player
//either switches doors every time or keeps their original door every time according to
//"switchDoors". As the simulation runs, it tallies up all the wins. Once all of the iterations have 
//been run, the total number of wins is output to the console, as well as the wins/iterations ratio
public class MontyHallSimulation : MonoBehaviour
{

    public int numOfIterations;
    public bool switchDoors;

    int winCounter = 0;
    int iterationCounter = 0;
    bool simulationRunning = true;


    void Update()
    {

    }




}
