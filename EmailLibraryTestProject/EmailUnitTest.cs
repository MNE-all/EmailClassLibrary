using EmailClassLibrary;

namespace EmailLibraryTestProject;

public class EmailUnitTest
{
    [Fact]
    public void GreenTest()
    {
        Assert.Equal(Email.Check("mne4@gmail.com"), true);
    }
    [Fact]
    public void RedTestWithoutDog()
    {
        Assert.Equal(Email.Check("mne4gmail.com"), false);
    }
    [Fact]
    public void RedTestWithoutDot()
    {
        Assert.Equal(Email.Check("mne4@gmailcom"), false);
    }
    [Fact]
    public void RedTestWithoutCom()
    {
        Assert.Equal(Email.Check("mne4@gmail."), false);
    }
    [Fact]
    public void RedTestWithoutGmail()
    {
        Assert.Equal(Email.Check("mne4@.com"), false);
    }
    [Fact]
    public void RedTestWithoutAddress()
    {
        Assert.Equal(Email.Check("@gmail.com"), false);
    }
}
