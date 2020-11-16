namespace Panel.DAL
{
    public class PanelSimorgh
    {
        public int PanelSimorghId { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int PhoneCall { get; set; }
        public int NationalCode { get; set; }
        public int BirthNo { get; set; }
        public int PostalCode { get; set; }
        public string Address { get; set; }
        public UserPanel userpanel  { get; set; }
        public Condition Con { get; set; }
        public Acquaintance acquaintanceType { get; set; }
        public TermsAcceptance terms { get; set; }
    }
}
