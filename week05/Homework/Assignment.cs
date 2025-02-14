public class Assignment {
    private string _userName;
    private string _topic;

    public Assignment(string userName, string topic) {
        _userName = userName;
        _topic = topic;
    }

    public string GetSummary() {
        return _userName + " - " + _topic;
    }

    public string GetName() {
        return _userName;
    }

    public string GetTopic() {
        return _topic;
    }
}