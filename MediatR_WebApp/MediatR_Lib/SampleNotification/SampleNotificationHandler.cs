using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_Lib.SampleNotification
{
    public class SampleNotificationHandler : INotificationHandler<SampleNotification>
    {
        public Task Handle(SampleNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => Debug.WriteLine($"params {notification.ValueOne}, secon {notification.Valuetwo}"));
        }
    }
}
