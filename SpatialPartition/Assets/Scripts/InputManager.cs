using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SpatialPartitionPattern
{
    public class InputManager : MonoBehaviour
    {
        public InputField NumberOfSoldiers;
        public GameController gc;

        public void SetNumSoldiers()
        {
            int newNumSoldiers;
            if (int.TryParse(NumberOfSoldiers.text, out newNumSoldiers))
            {
                gc.Reload(newNumSoldiers);
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }
    }

}