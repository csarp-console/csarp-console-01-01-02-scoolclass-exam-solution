namespace SchoolClassProject
{
    public class SchoolClass
    {
        public SchoolClass(int grade, string schoolClassId, int classFee, int numberOfStudent)
        {
            Grade = grade;
            SchoolClassId = schoolClassId;
            ClassFee = classFee;
            NumberOfStudent = numberOfStudent;
        }

        public int Grade { get; set; }
        public string SchoolClassId { get; set; } 
        public int ClassFee { get; set; }
        public int NumberOfStudent {  get; set; }

        public string ShortClassName => $"{Grade}.{SchoolClassId}";

        public override string ToString()
        {
            return $"{Grade}.{SchoolClassId} ({ClassFee})";
        }
    }
}
