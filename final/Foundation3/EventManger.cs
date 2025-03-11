public class EventManager {
    private Address _LAddress;
    private Address _RAddress;
    private Address _OAddress;
    private LectureEvent _lecture;
    private OutdoorEvent _outdoor;
    private ReceptionEvent _reception;

    public EventManager()
    {
        _LAddress = new Address("7777 old farm ln","Prattville","Alabama","United States");
        _RAddress = new Address("7777 shady road","el chapo","Mexico city","Mexico");
        _OAddress = new Address("2000 mormon road","provo","Utah","United States");
        _lecture = new LectureEvent("Lecture", "Lecture on coding", "12/20/2025", "7:00pm", _LAddress ,"Yujin Lim", 100);
        _outdoor = new OutdoorEvent("outdoor", "concert with 10 different singers", "1/19/2025", "10:00pm", _OAddress, "Sunny");
        _reception = new ReceptionEvent("Reception", "Reception for lasertag", "10/18/2025", "5:00pm", _RAddress, "jujin.0348@gmail.com");
    }

    public void LDisplay1()
    {
        _lecture.DisplayShort();
    }

    public void LDisplay2()
    {
        _lecture.DisplayStandard();
    }

    public void LDisplay3()
    {
        _lecture.DisplayFull();
    }

    public void RDisplay1()
    {
        _reception.DisplayShort();
    }

    public void RDisplay2()
    {
        _reception.DisplayStandard();
    }

    public void RDisplay3()
    {
        _reception.DisplayFull();
    }


    public void ODisplay1()
    {
        _outdoor.DisplayShort();
    }

    public void ODisplay2()
    {
        _outdoor.DisplayStandard();
    }

    public void ODisplay3()
    {
        _outdoor.DisplayFull();
    }


}