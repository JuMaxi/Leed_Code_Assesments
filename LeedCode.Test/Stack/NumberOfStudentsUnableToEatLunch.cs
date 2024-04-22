namespace LeedCode.Test.Stack;

public class NumberOfStudentsUnableToEatLunch
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        Stack<int> stack = ConvertArraySandwichesToStack(sandwiches);
        Queue<int> queue = ConvertArrayStudentsToQueue(students);

        int throughQueue = 0;

        while(stack.Count > 0 && queue.Count > throughQueue)
        {
            int firstStudent = queue.Dequeue();
            int topSandwiche = stack.Peek();

            if (firstStudent == topSandwiche)
            {
                stack.Pop();
                throughQueue = 0;
            }
            else
            {
                queue.Enqueue(firstStudent);
                throughQueue++;
            }
        }

        return stack.Count;
    }

    private Stack<int> ConvertArraySandwichesToStack(int[] sandwiches)
    {
        Stack<int> stack = new();

        for(int i = sandwiches.Length - 1; i >= 0; i--)
        {
            stack.Push(sandwiches[i]);
        }

        return stack;
    }

    private Queue<int> ConvertArrayStudentsToQueue(int[] students)
    {
        Queue<int> queue = new();

        for(int i = 0;i < students.Length; i++)
        {
            queue.Enqueue(students[i]);
        }

        return queue;
    }
}
