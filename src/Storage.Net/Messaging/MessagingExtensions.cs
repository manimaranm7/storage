﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Net.Messaging
{
   /// <summary>
   /// Messaging extensions
   /// </summary>
   public static class MessagingExtensions
   {
      /// <summary>
      /// Puts a single message into the queue
      /// </summary>
      /// <param name="publisher">Publisher reference</param>
      /// <param name="message">Message to put</param>
      public static void PutMessage(this IMessagePublisher publisher, QueueMessage message)
      {
         if (message == null) throw new ArgumentNullException(nameof(message));

         publisher.PutMessages(new[] { message });
      }

      /// <summary>
      /// Puts a single message into the queue
      /// </summary>
      /// <param name="publisher">Publisher reference</param>
      /// <param name="message">Message to put</param>
      public static async Task PutMessageAsync(this IMessagePublisher publisher, QueueMessage message)
      {
         if (message == null) throw new ArgumentNullException(nameof(message));

         await publisher.PutMessagesAsync(new[] { message });
      }
   }
}
