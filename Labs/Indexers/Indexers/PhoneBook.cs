using System;

namespace Indexers
{
	sealed class PhoneBook
	{
        private int used;
        private Name[] names;
        private PhoneNumber[] phoneNumbers;

		public PhoneBook()
		{
			int initialSize = 0;
			this.used = 0;
			this.names = new Name[initialSize];
			this.phoneNumbers = new PhoneNumber[initialSize];
		}
		
		public void Add(Name name, PhoneNumber number)
		{
			enlargeIfFull();
			this.names[used] = name;
			this.phoneNumbers[used] = number;
			this.used++;
		}
		//This keyword: 3 uses 
		// (1) Qualify members hidden by similar names
		// (2) pass an object as a parameter to other methods
		// (3) declare indexers (one per class)
		public Name this[PhoneNumber number]	//declare an indexer called this
		{
			get
			{
				int i = Array.IndexOf(this.phoneNumbers, number);
				//if IndexOf doesnt find the object its looking for - returns -1
				if (i != -1)
				{
					return this.names[i];
				}
				else
				{
					return new Name(); //creates a new reference type - init as null
				}
			}
			//this indexer looks through the phonenumber array for the input number
			//if the number exists it returns the name
			//if the number doesnt exist it returns null
		}
		public PhoneNumber this[Name name] //overloads the this indexer to take name inut
		{
			get
			{
				int i = Array.IndexOf(this.names, name); //searches for the name
				if (i != -1)
				{
					return this.phoneNumbers[i]; //gives you the corresponding number
				}
				else
				{
					return new PhoneNumber();	//new reference type - returns null
				}
			}
		}
		private void enlargeIfFull()
		{
			if (this.used == this.names.Length)
			{
				int bigger = used + 16;
				
				Name[] moreNames = new Name[bigger];
				this.names.CopyTo(moreNames, 0);
				
				PhoneNumber[] morePhoneNumbers = new PhoneNumber[bigger];
				this.phoneNumbers.CopyTo(morePhoneNumbers, 0);
						
				this.names = moreNames;
				this.phoneNumbers = morePhoneNumbers;
			}
		}
	}
}