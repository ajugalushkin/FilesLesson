using System.Text;

const string path = "A:\\Users\\ajuga\\source\\repos\\FilesLesson\\";

string nameInputFile = "ISP_20_2.dat";
//Encoding win1251 = Encoding.GetEncoding("windows-1251");

string[] studentsData = File.ReadAllLines(path + nameInputFile);

List<string> studentsDataFinal = new List<string>();

foreach (string studentData in studentsData)
{
    string[] splitedData = studentData.Split("\t");

    double studentGradeAverage = 0;
    int countGrade = 0;
    for (int i = 1; i < splitedData.Length; i++)
    {
        try
        {
            studentGradeAverage += double.Parse(splitedData[i]);
            countGrade++;
        }
        catch (Exception)
        {
            studentGradeAverage += 0;
        }
    }

    studentGradeAverage = studentGradeAverage / countGrade;

    if (studentGradeAverage > 3)
    {
        studentsDataFinal.Add($"{ splitedData[0] } { studentGradeAverage } - зачет");
    }

}

string nameOutputFile = "ISP_20_2_NEW.dat";
File.WriteAllLines(path + nameOutputFile, studentsDataFinal);
