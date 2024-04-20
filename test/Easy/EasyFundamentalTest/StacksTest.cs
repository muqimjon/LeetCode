using EasyFundamental;

namespace EasyFundamentalTest;

public class StacksTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 6)]
    [InlineData(7, 8, 9)]
    public void MyStack_PushPopTopEmpty(params int[] elements)
    {
        MyStack stack = new MyStack();

        foreach (int element in elements)
        {
            stack.Push(element);
            Assert.Equal(element, stack.Top());
        }

        for (int i = elements.Length - 1; i >= 0; i--)
        {
            int popped = stack.Pop();
            Assert.Equal(elements[i], popped);
        }

        Assert.True(stack.Empty());
    }
}