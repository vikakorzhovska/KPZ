using Task3;

Authenticator auth1 = Authenticator.GetInstance();
Authenticator auth2 = Authenticator.GetInstance();

Console.WriteLine(ReferenceEquals(auth1, auth2) ? "Same instance!" : "Different instances!");

auth1.Authenticate();