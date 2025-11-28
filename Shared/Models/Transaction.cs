namespace Shared.Models
{
    public class Transaction
    {
        private int _id;
        private int _accountId;
        private decimal _amount;
        private int _currencyId;
        private DateTime _trxDate;
        private string _description = "";
        private int _requestedByUserId;
        private int _statusId;
        private int _trxTypeId;
        private int _createdByUserId;
        private int _lastModifiedByUserId;
        private DateTime _dateCreated;
        private DateTime _dateModified;
        private bool _isIncome;
        private string _receiptPath="";
        private int _categoryId;
        private int _projectId;
        private int _subCategoryId;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int AccountId
        {
            get { return _accountId; }
            set { _accountId = value; }
        }

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public int CurrencyId
        {
            get { return _currencyId; }
            set { _currencyId = value; }
        }
        public DateTime TrxDate
        {
            get { return _trxDate; }
            set { _trxDate = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int CreatedByUserId
        {
            get { return _createdByUserId; }
            set { _createdByUserId = value; }
        }
        public int LastModifiedByUserId
        {
            get { return _lastModifiedByUserId; }
            set { _lastModifiedByUserId = value; }
        }
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }
        public DateTime DateModified
        {
            get { return _dateModified; }
            set { _dateModified = value; }
        }
        public bool IsIncome
        {
            get { return _isIncome; }
            set { _isIncome = value; }
        }
        public int StatusId
        {
            get { return _statusId; }
            set { _statusId = value; }
        }
        public int TrxTypeId
        {
            get { return _trxTypeId; }
            set { _trxTypeId = value; }
        }
        public int RequestedByUserId
        {
            get { return _requestedByUserId; }
            set { _requestedByUserId = value; }
        }
        public string ReceiptPath
        {
            get { return _receiptPath; }
            set { _receiptPath = value; }
        }
        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }
        public int SubCategoryId
        {
            get { return _subCategoryId; }
            set { _subCategoryId = value; }
        }
        public int ProjectId
        {
            get { return _projectId; }
            set { _projectId = value; }
        }
    }
}
