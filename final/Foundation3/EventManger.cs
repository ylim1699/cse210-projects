public class EventManager {
    private LectureEvent _lecture = new LectureEvent("Lecture", "Lecture on coding", "12/20/2025", "7:00pm", new Address("7777 old farm ln","Prattville","Alabama","United States"),"Yujin Lim", 100 );

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

    private ReceptionEvent _reception = new ReceptionEvent("Reception", "Reception for lasertag", "10/18/2025", "5:00pm", new Address("7777 shady road","el chapo","Mexico city","Mexico"),"jujin.0348@gmail.com");

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

    private OutdoorEvent _outdoor = new OutdoorEvent("outdoor", "concert with 10 different singers", "1/19/2025", "10:00pm", new Address("2000 mormon road","provo","Utah","United States"),"Sunny");

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