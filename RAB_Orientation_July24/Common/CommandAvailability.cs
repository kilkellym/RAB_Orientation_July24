namespace RAB_Orientation_July24.Common
{
	internal class CommandAvailability : IExternalCommandAvailability
	{
		public bool IsCommandAvailable(UIApplication applicationData, CategorySet selectedCategories)
		{
			bool result = false;
			UIDocument activeDoc = applicationData.ActiveUIDocument;
			if (activeDoc != null && activeDoc.Document != null)
			{
				result = true;
			}

			return result;
		}
	}
}
