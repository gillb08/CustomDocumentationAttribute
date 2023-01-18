namespace DocumentedAttribute
{

    [Document("This is a class attribute describing a Trainee")]
    class Trainee
    {

        [Document("This is a constructor attribute describing a Trainee", Input = "victor", Output = "The Trainee name is VIctor Gilbert")]
        public Trainee(string fullname, string cohort)
        {
            Fullname = fullname;
            Cohort = cohort;
        }


        [Document("This is a Cohort property attribute of a Trainee", Input = "Cohort 3", Output = "Cohort 3")]
        public string Cohort { get; private set; }


        [Document("This is a Fullname property attribute of a Trainee", Input = "victor Gilbert", Output = "The Trainee fullname is Victor Gilbert")]
        public string Fullname { get; private set; }


        [Document("This is a Trainee Scream style enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
        enum TraineeScreams
        {
            [Document("This is a Trainee Scream enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
            Oh!!,

            [Document("This is a Trainee Scream enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
            Pheww,

            [Document("This is a Trainee Scream enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
            Omg,

            [Document("This is a Trainee Scream enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
            Damn
        }

        [Document("This is a get Trainee Scream method attribute", Input = "input may be enum", Output = "enum choosen")]
        public static void GetTraineeScreams() => Console.WriteLine(TraineeScreams.GodAbeg);

    }
}
