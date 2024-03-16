function Header(props: any) {
  return (
    <header className="row">
      <div className="col-4">
        <h1>Bowlers</h1>
        <h4>{props.title}</h4>
      </div>
    </header>
  );
}
export default Header;
