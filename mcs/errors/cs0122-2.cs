// cs0122.cs: prop is not accessible due to its protection level
//
class A
{
        int i;

        int prop
        {
                set { i = value; }
        }
}

class B : A
{
        void M ()
        {
                prop = 2;
        }
}
