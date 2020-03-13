<?php
/**
 * A page controller
 */
require "config.php";
require "functions.php";

$search = $_GET["search"] ?? null;
$like = "%$search%";

if ($search) {
    $db = connectDatabase($dsn);
    $sql = <<<EOD
SELECT
    *
FROM tech
WHERE
    id = ?
    OR label LIKE ?
    OR type LIKE ?
; 
EOD;
    $stmt = $db->prepare($sql);
    $stmt->execute([$search, $like, $like]);
    $res = $stmt->fetchAll();

    echo var_dump($res);

}

?>
<?php
require __DIR__."/view/header.php";
?>
<h1>Search</h1>

<form>
<p>
    <label>Search: 
        <input type="text" name="search" value="<?= $search ?>">
    </label>
</p>
</form>
<?php
require __DIR__."/view/footer.php";
?>