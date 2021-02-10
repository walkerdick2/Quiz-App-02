Imports System.Text

Module Main

    Public AQuiz As Quiz = New Quiz()

    Public Sub Create_Main()

        AQuiz.Questions.Add(Make_Question("At the beginning of a regular soccer game there should be 11 players on the field.", True, 10))
        AQuiz.Questions.Add(Make_Question("When Michael Jordan played for the Chicago Bulls he only won 2 NBA championships.", False, 10))
        AQuiz.Questions.Add(Make_Question("Dead people can not get goose bumps.", False, 10))
        AQuiz.Questions.Add(Make_Question("Ostriches stick their heads in the sand when they feel threatened.", False, 10))
        AQuiz.Questions.Add(Make_Question("Napoleon Bonaparte wasn't short; his height was actually above average for his time", True, 10))
        AQuiz.Questions.Add(Make_Question("The state sport of Maryland is jousting", True, 10))
        AQuiz.Questions.Add(Make_Question("Lightning never strikes in the same place twice.", False, 10))
        AQuiz.Questions.Add(Make_Question("If you cry in space the tears just stick to your face.", True, 10))
        AQuiz.Questions.Add(Make_Question("The capital of Libya is Benghazi", True, 10))
        AQuiz.Questions.Add(Make_Question("Albert Einstein was awarded the Nobel Prize in Literature", False, 10))
        AQuiz.Questions.Add(Make_Question("Baby koalas are called joeys", False, 10))
        AQuiz.Questions.Add(Make_Question("If you cut an earthworm in half, both halves can regrow their body.", False, 10))
        AQuiz.Questions.Add(Make_Question("Humans can distinguish between over a trillion different smells.", True, 10))
        AQuiz.Questions.Add(Make_Question("The Spanish national anthem has no words.", True, 10))
        AQuiz.Questions.Add(Make_Question("When you extract all of the gold from the bubbling core of the earth you would be able to cover all of the lands in a layer of gold up to your knees.", True, 10))
        AQuiz.Questions.Add(Make_Question("Brazil is the only country in the Americas whose official language is Portuguese.", True, 10))
        AQuiz.Questions.Add(Make_Question("The first name of Kramer in Seinfeld is Cosmo", True, 10))
        AQuiz.Questions.Add(Make_Question("The American Civil War ended in 1776.", False, 50))
        AQuiz.Questions.Add(Make_Question("You couldn't feasibly eat 3000-year-old honey. It spoils.", False, 10))
        AQuiz.Questions.Add(Make_Question("It would take 1,200,000 mosquitoes, each sucking once to completely drain the average human of blood.", True, 10))
        AQuiz.Questions.Add(Make_Question("You taste different flavors with different parts of your tongue.", False, 10))
        AQuiz.Questions.Add(Make_Question("It can take a photon 40,000 years to travel from the core of the sun to the surface" + System.Environment.NewLine + "but only 8 minutes to travel the rest of the way to earth.", True, 10))
        AQuiz.Questions.Add(Make_Question("Cleopatra lived closer in time to the Moon landing than to the construction of the Great Pyramid of Giza.", True, 10))
        AQuiz.Questions.Add(Make_Question("There are more possible iterations of a game of chess than there are atoms in the known universe.", True, 10))
        AQuiz.Questions.Add(Make_Question("A right triangle can never be equilateral.", True, 20))
        AQuiz.Questions.Add(Make_Question("The Ford Edsel was named after Henry Ford’s father.", False, 10))
        AQuiz.Questions.Add(Make_Question("Adults have fewer bones than babies do.", True, 20))
        AQuiz.Questions.Add(Make_Question("Goldfish only have a memory of three seconds.", False, 10))
        AQuiz.Questions.Add(Make_Question("The Bill of Rights contains 10 amendments to the Constitution.", True, 50))
        AQuiz.Questions.Add(Make_Question("Vaccines cause autism.", False, 100))

    End Sub
    Public Function Make_Question(Text As String, Answer As Boolean, Points As Integer) As Question
        Dim modified_string = New StringBuilder
        'Debug.WriteLine(Text.Length.ToString)

        Dim Question As New Question()
        Dim Cutoff = 75
        If Text.Length > Cutoff Then
            modified_string.Append(Text.Substring(0, Cutoff))

            Debug.WriteLine((Text.Length - Cutoff).ToString)
            modified_string.Append(System.Environment.NewLine)
            modified_string.Append(Text.Substring((Cutoff + 1), (Text.Length - (Cutoff + 1))))

            'Question.Text = modified_string.ToString
            Debug.WriteLine("Split:" + Text.Length.ToString)
            Debug.WriteLine(modified_string.ToString)
            Question.Text = modified_string.ToString
        Else
            Debug.WriteLine("No Split:" + Text.Length.ToString)
            Debug.WriteLine(Text)
            Question.Text = Text
        End If

        Question.Answer = Answer
        Question.Points = Points

        Return Question
    End Function
End Module

