    public class Person
    {
        private string firstName;
        private string lastName;
	    private int age;

        public Person(String firstName, String lastName)
        {
            this.setFirstName = (firstName);
            this.setLastName = (lastName);
        }

        public void SetFirstName(String firstName) throws IllegalArgumentException {
	if (firstName.isEmpty())
		throw new IllegalArgumentException("Cant pass empty first name");
        {
            this.firstName = firstName;
        }

        public void SetLastName(String lastName)
        {
            this.lastName = lastName;
        }
    }

