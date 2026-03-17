using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Week05
{
    public class Week05Loading : MonoBehaviour
    {
        async Task Start()
        {
            /*
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
            
            
            StartCoroutine(LoadingScene(1));
            StartCoroutine(LoadingScene(2));
            */
            await SceneManager.LoadSceneAsync(1,LoadSceneMode.Additive);
            await SceneManager.LoadSceneAsync(1,LoadSceneMode.Additive);
            LightProbes.Tetrahedralize();
        }

        IEnumerator LoadingScene(int sceneNum)
        {
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneNum, LoadSceneMode.Additive);
            while (asyncOperation.isDone == false)
            {
                print("isLoading : " + asyncOperation.progress + "% completed");
                yield return null;
            }
            LightProbes.Tetrahedralize();
            yield return null;
        }
    }
}