using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace PlayerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuctionService" in both code and config file together.
    [ServiceContract]
    public interface IAuctionService
    {
        [OperationContract]
        DataSet GetAuctions();

        [OperationContract]
        string AddAuction(Auction auction);

        [OperationContract]
        string DeleteAuction(int id);

        [OperationContract]
        string UpdateAuction(Auction auction);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}
