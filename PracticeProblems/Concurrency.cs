using System;
using System.Threading.Tasks;


namespace PracticeProblems
{
    public class Foo 
    {
        private TaskCompletionSource _f;
        private TaskCompletionSource _s;

        public Foo() {
            _f = new TaskCompletionSource();
            _s = new TaskCompletionSource();
            
        }

        public void First(Action printFirst) {
            
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            _f.SetResult();
        }

        public void Second(Action printSecond) {

            _f.Task.Wait();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            _s.SetResult();
        }

        public void Third(Action printThird) {
            
            _s.Task.Wait();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}