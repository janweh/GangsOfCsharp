namespace WindowsFormsApp15.view
{
    class SearchConditionChecker
    {
        MainWindow mw;
        public SearchConditionChecker(MainWindow mw)
        {
            this.mw = mw;
        }
        public bool NoFieldsSelected()
        {
            return mw.GetUniversityComboBox() == mw.NoSelectedUniversity &&
                mw.GetMajorComboBox() == mw.NoSelectedMajor &&
                (mw.GetProfessorComboBox() == null || mw.GetProfessorComboBox() == mw.NoSelectedLecturer)
                && mw.GetCourseNameTextField().Equals("");
        }

        public bool OnlyUniversitySelected()
        {
            return mw.GetUniversityComboBox() != mw.NoSelectedUniversity &&
                mw.GetMajorComboBox() == mw.NoSelectedMajor &&
                (mw.GetProfessorComboBox() == null ||
                mw.GetProfessorComboBox() == mw.NoSelectedLecturer)
                && mw.GetCourseNameTextField().Equals("");
        }

        public bool MajorAndUniversitySelected()
        {
            return mw.GetUniversityComboBox() != mw.NoSelectedUniversity &&
                mw.GetMajorComboBox() != mw.NoSelectedMajor &&
                (mw.GetProfessorComboBox() == null ||
                mw.GetProfessorComboBox() == mw.NoSelectedLecturer)
                && mw.GetCourseNameTextField().Equals("");
        }

        public bool ProfessorSelected()
        {
            return (mw.GetProfessorComboBox() != null &&
                mw.GetProfessorComboBox() != mw.NoSelectedLecturer) &&
                mw.GetCourseNameTextField().Equals("");
        }

        public bool OnlyMajorSelected()
        {
            return mw.GetUniversityComboBox() == mw.NoSelectedUniversity &&
                mw.GetMajorComboBox() != mw.NoSelectedMajor &&
                (mw.GetProfessorComboBox() == null ||
                mw.GetProfessorComboBox() == mw.NoSelectedLecturer)
                && mw.GetCourseNameTextField().Equals("");
        }

        public bool CourseNameEntered()
        {
            return !mw.GetCourseNameTextField().Equals("");
        }

        public bool EnableProfessor()
        {
            return mw.GetUniversityComboBox() != mw.NoSelectedUniversity &&
                mw.GetMajorComboBox() != mw.NoSelectedMajor;
        }
    }
}
