Our Project has mainly 4 scenes

Scene 1_Change the color of large squares:
In this scene, users can change the color of two large squares using trigger buttons on controllers and observe how it affects the color of the middle square. We have noticed that certain colors can show intriguing color variations in the middle squares.

Scene 2_Change color in outer blindfold:
We enable users to change the color of the outer blindfold. It has come to our attention that certain colors in the outer blindfold can produce intriguing variations in the middle squares.

Scene 3_Combine small squares:
When the small squares are combined, we can easily notice similarities between the colors in the middle squares.

Scene 4_Change background color to black:
In this scene, we can observe how the color of the middle squares appears in a black background and with more gap between the large squares.

Additionally, we have added a next button in the Game window to navigate to next scene. It can be accessible by only mouse click. For that, we created a button which is in a canvas and add a script to the button to trigger the click event.

Here is the snapshot of the c# code for button click:

public class SceneNavigator : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

These are the steps to execute the project:

 - First run the unity project
 - Then the trigger button on the controller can be used to change the color of the large squares 
 - Then click the next button in the Game window to navigate the next scene
 - Same steps can be followed in next scenes as well.

# Reality Hood - Virtual Reality Project

### The Project has mainly 4 scenes

#### 1. Scene 1_Change the color of large squares
##### In this scene, users can change the color of two large squares using trigger buttons on controllers and observe how it affects the color of the middle square. We have noticed that certain colors can show intriguing color variations in the middle squares.

#### 2. Install Python version 3.x

#### 3. Run requirements.txt file by the following command to install all the dependencies

### Steps to Run the project

#### 1. Download the HistWord pretrained models from <http://snap.stanford.edu/historical_embeddings/eng-fiction-all_sgns.zip>

#### 2. Install Python version 3.x

#### 3. Run requirements.txt file by the following command to install all the dependencies

> pip install -r requirements.txt

#### 4. start the jupyter notebook. Run the following command.

> jupyter notebook

#### 5. A browser window will open on localhost:8888

#### 6. Find the notebook named "Analyze_dataset_combined.ipynb" using the file explorer given in the jupyter server UI

#### 7. Now you can execute the code line by line and see the results.
