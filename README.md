
#README for  CustomDocumentationAttribute


#Description
This is a namespace that includes a Trainee class with several attributes and methods. The Trainee class has a constructor, properties for Fullname and Cohort, an enumeration for TraineeScreams, and a method for GetTraineeScreams. Each of these elements has a Document attribute that provides a brief description of what the element does and what kind of input and output to expect.

#Usage
To use the DocumentedAttribute namespace, you can create a new instance of the Trainee class by passing in the full name and cohort of the trainee as strings. You can then access the Cohort and Fullname properties, as well as the TraineeScreams enumeration. The GetTraineeScreams method will output the GodAbeg value of the TraineeScreams enumeration.

```[CustomDocumentation("This is a sample class")]
public class SampleClass {
  [CustomDocumentation("This is a sample method")]
  public void SampleMethod() {
    // method implementation
  }
}```

#you can Access using Reflection, E.g

```var type = typeof(SampleClass);
var attribute = type.GetCustomAttribute<CustomDocumentationAttribute>();
string documentation = attribute.Documentation;
Console.WriteLine(documentation);```




